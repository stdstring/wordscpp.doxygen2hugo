namespace Doxygen2HugoConverter.Lookup
{
    internal class LookupManager
    {
        public LookupManager(LookupData sourceData)
        {
            _weightDelta = sourceData.Delta;
            _sourceRoot = new LookupItem (String.Empty, 0, sourceData.Children);
        }

        public LookupFrame EnterRootFrame()
        {
            _destRoot = new LookupItem(String.Empty, 0);
            return new LookupFrame(_sourceRoot, _weightDelta, _destRoot);
        }

        public LookupData GetDestData()
        {
            return _destRoot switch
            {
                null => new LookupData(_weightDelta),
                _ => new LookupData(_weightDelta, _destRoot.Children)
            };
        }

        private readonly Int32 _weightDelta;
        private readonly LookupItem _sourceRoot;
        private LookupItem? _destRoot;
    }

    internal class LookupFrame : IDisposable
    {
        public LookupFrame(LookupItem? sourceItem, Int32 weightDelta, LookupItem destItem)
        {
            _weightDelta = weightDelta;
            _destItem = destItem;
            _sourceChildrenMap = sourceItem?.Children?.ToDictionary(childItem => childItem.Name) ?? new Dictionary<String, LookupItem>();
        }

        public LookupFrame EnterChild(String name)
        {
            LookupItem? sourceChild = _sourceChildrenMap.ContainsKey(name) switch
            {
                true => _sourceChildrenMap[name],
                false => null
            };
            LookupItem destChild = _destChildrenMap[name];
            return new LookupFrame(sourceChild, _weightDelta, destChild);
        }

        public void AppendKnownChildren(String[] entries)
        {
            Int32 prevWeight = 0;
            Queue<String> unprocessedEntries = new Queue<String>();
            foreach (String entry in entries)
            {
                if (_sourceChildrenMap.ContainsKey(entry) && CanProcessEntries(prevWeight, _sourceChildrenMap[entry].Weight, unprocessedEntries))
                {
                    LookupItem sourceItem = _sourceChildrenMap[entry];
                    ProcessEntries(prevWeight, sourceItem.Weight, unprocessedEntries);
                    LookupItem destItem = new LookupItem(entry, sourceItem.Weight);
                    _destChildren.Add(destItem);
                    _destChildrenMap.Add(entry, destItem);
                    prevWeight = destItem.Weight;
                }
                else
                    unprocessedEntries.Enqueue(entry);
            }
            ProcessEntries(prevWeight, null, unprocessedEntries);
        }

        public Int32 CurrentWeight => _destItem.Weight;

        public Int32 GetChildWeight(String name)
        {
            return _destChildrenMap[name].Weight;
        }

        public void Dispose()
        {
            _destItem.Children = _destChildren.ToArray();
        }

        private Boolean CanProcessEntries(Int32 prevWeight, Int32 nextWeight, Queue<String> entries) => entries.Count <= (nextWeight - prevWeight - 1);

        private void ProcessEntry(Int32 entryWeight, Queue<String> entries)
        {
            String entry = entries.Dequeue();
            LookupItem destItem = new LookupItem(entry, entryWeight);
            _destChildren.Add(destItem);
            _destChildrenMap.Add(entry, destItem);
        }

        private void ProcessEntries(Int32 prevWeight, Int32? nextWeight, Queue<String> entries)
        {
            Int32 currentWeight = prevWeight;
            switch (nextWeight)
            {
                case null:
                    while (entries.Count > 0)
                    {
                        currentWeight += _weightDelta;
                        ProcessEntry(currentWeight, entries);
                    }
                    break;
                case var _:
                    Int32 freeNumbers = nextWeight.Value - prevWeight - 1 - entries.Count;
                    Int32 delta = freeNumbers / (entries.Count + 1);
                    while (entries.Count > 0)
                    {
                        Int32 currentDelta = delta + (delta * (entries.Count + 1) < freeNumbers ? 1 : 0);
                        currentWeight += (1 + currentDelta);
                        freeNumbers -= currentDelta;
                        ProcessEntry(currentWeight, entries);
                    }
                    break;
            }
        }

        private readonly Int32 _weightDelta;
        private readonly IDictionary<String, LookupItem> _sourceChildrenMap;
        private readonly LookupItem _destItem;
        private readonly IList<LookupItem> _destChildren = new List<LookupItem>();
        private readonly IDictionary<String, LookupItem> _destChildrenMap = new Dictionary<String, LookupItem>();
    }
}
