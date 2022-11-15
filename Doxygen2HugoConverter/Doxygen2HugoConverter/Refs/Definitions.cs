namespace Doxygen2HugoConverter.Refs
{
    internal abstract record NamespaceEntityRef
    {
        internal record EnumEntityRef(String RefId, String Name) : NamespaceEntityRef;

        internal record TypedefEntityRef(String RefId, String Name) : NamespaceEntityRef;

        private NamespaceEntityRef()
        {
        }
    }

    internal record NamespaceRef(String RefId, String Name, NamespaceEntityRef[] ChildEntities);

    internal record MemberRef(String RefId, String Name);
}
