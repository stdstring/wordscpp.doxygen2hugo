﻿using Doxygen2HugoConverter.Lookup;
using NUnit.Framework;

namespace Doxygen2HugoConverter.Tests.Lookup
{
    [TestFixture]
    public class WeightGenerationTests
    {
        [Test]
        public void GenerateForEmptySource()
        {
            LookupData source = new LookupData(500);
            LookupManager lookupManager = new LookupManager(source);
            using (LookupFrame rootFrame = lookupManager.EnterRootFrame())
            {
                rootFrame.AppendKnownChildren(new []{"Aspose::Words", "Aspose::Words::BuildingBlocks", "Aspose::Words::Field"});
                CheckWeights(rootFrame, new []{"Aspose::Words", "Aspose::Words::BuildingBlocks", "Aspose::Words::Field"}, new []{500, 1000, 1500});
                using (LookupFrame namespace1Frame = rootFrame.EnterChild("Aspose::Words"))
                {
                    namespace1Frame.AppendKnownChildren(new []{"Body", "Node"});
                    CheckWeights(namespace1Frame, new []{"Body", "Node"}, new []{500, 1000});
                }
                using (LookupFrame namespace3Frame = rootFrame.EnterChild("Aspose::Words::Field"))
                {
                    namespace3Frame.AppendKnownChildren(new[] {"Field", "FieldChar", "FieldDate"});
                    CheckWeights(namespace3Frame, new []{"Field", "FieldChar", "FieldDate"}, new []{500, 1000, 1500});
                }
            }
            LookupData expected = new LookupData(500,
                new[]
                {
                    new LookupItem("Aspose::Words", 500, new []{new LookupItem("Body", 500), new LookupItem("Node", 1000)}),
                    new LookupItem("Aspose::Words::BuildingBlocks", 1000),
                    new LookupItem("Aspose::Words::Field", 1500, new []{new LookupItem("Field", 500), new LookupItem("FieldChar", 1000), new LookupItem("FieldDate", 1500)})
                });
            LookupDataChecker.Check(expected, lookupManager.GetDestData());
        }

        [Test]
        public void GenerateForSameSourceDest()
        {
            LookupData source = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10, new []{new LookupItem("Body", 10), new LookupItem("Node", 20)}),
                    new LookupItem("Aspose::Words::BuildingBlocks", 20),
                    new LookupItem("Aspose::Words::Field", 30, new []{new LookupItem("Field", 10), new LookupItem("FieldChar", 20), new LookupItem("FieldDate", 30)})
                });
            LookupManager lookupManager = new LookupManager(source);
            using (LookupFrame rootFrame = lookupManager.EnterRootFrame())
            {
                rootFrame.AppendKnownChildren(new[] {"Aspose::Words", "Aspose::Words::BuildingBlocks", "Aspose::Words::Field"});
                CheckWeights(rootFrame, new []{"Aspose::Words", "Aspose::Words::BuildingBlocks", "Aspose::Words::Field"}, new []{10, 20, 30});
                using (LookupFrame namespace1Frame = rootFrame.EnterChild("Aspose::Words"))
                {
                    namespace1Frame.AppendKnownChildren(new[] {"Body", "Node"});
                    CheckWeights(namespace1Frame, new []{"Body", "Node"}, new []{10, 20});
                }
                using (LookupFrame namespace3Frame = rootFrame.EnterChild("Aspose::Words::Field"))
                {
                    namespace3Frame.AppendKnownChildren(new[] {"Field", "FieldChar", "FieldDate"});
                    CheckWeights(namespace3Frame, new []{"Field", "FieldChar", "FieldDate"}, new []{10, 20, 30});
                }
            }
            LookupData expected = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10, new []{new LookupItem("Body", 10), new LookupItem("Node", 20)}),
                    new LookupItem("Aspose::Words::BuildingBlocks", 20),
                    new LookupItem("Aspose::Words::Field", 30, new []{new LookupItem("Field", 10), new LookupItem("FieldChar", 20), new LookupItem("FieldDate", 30)})
                });
            LookupDataChecker.Check(expected, lookupManager.GetDestData());
        }

        [Test]
        public void GenerateForAddSourceInDest()
        {
            LookupData source = new LookupData(20,
                new[]
                {
                    new LookupItem("Aspose::Words::Field", 20, new []{new LookupItem("FieldDate", 20), new LookupItem("FieldIf", 40)})
                });
            LookupManager lookupManager = new LookupManager(source);
            using (LookupFrame rootFrame = lookupManager.EnterRootFrame())
            {
                rootFrame.AppendKnownChildren(new[] {"Aspose::Words", "Aspose::Words::Field", "Aspose::Words::Fonts"});
                CheckWeights(rootFrame, new []{"Aspose::Words", "Aspose::Words::Field", "Aspose::Words::Fonts"}, new []{10, 20, 40});
                using (LookupFrame namespaceFrame = rootFrame.EnterChild("Aspose::Words::Field"))
                {
                    namespaceFrame.AppendKnownChildren(new[] {"Field", "FieldChar", "FieldDate", "FieldDde", "FieldEnd", "FieldEQ", "FieldIf", "FieldRD"});
                    CheckWeights(namespaceFrame,
                                 new []{"Field", "FieldChar", "FieldDate", "FieldDde", "FieldEnd", "FieldEQ", "FieldIf", "FieldRD"},
                                 new []{7, 14, 20, 25, 30, 35, 40, 60});
                }
            }
            LookupData expected = new LookupData(20,
                new[]
                {
                    new LookupItem("Aspose::Words", 10),
                    new LookupItem("Aspose::Words::Field", 20, new []
                    {
                        new LookupItem("Field", 7),
                        new LookupItem("FieldChar", 14),
                        new LookupItem("FieldDate", 20),
                        new LookupItem("FieldDde", 25),
                        new LookupItem("FieldEnd", 30),
                        new LookupItem("FieldEQ", 35),
                        new LookupItem("FieldIf", 40),
                        new LookupItem("FieldRD", 60)
                    }),
                    new LookupItem("Aspose::Words::Fonts", 40)
                });
            LookupDataChecker.Check(expected, lookupManager.GetDestData());
        }

        [Test]
        public void GenerateForRemoveSourceInDest()
        {
            LookupData source = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10, new []{new LookupItem("Body", 10), new LookupItem("Node", 20)}),
                    new LookupItem("Aspose::Words::BuildingBlocks", 20),
                    new LookupItem("Aspose::Words::Field", 30, new []{new LookupItem("Field", 10), new LookupItem("FieldChar", 20), new LookupItem("FieldDate", 30)})
                });
            LookupManager lookupManager = new LookupManager(source);
            using (LookupFrame rootFrame = lookupManager.EnterRootFrame())
            {
                rootFrame.AppendKnownChildren(new[] {"Aspose::Words", "Aspose::Words::Field"});
                CheckWeights(rootFrame, new []{"Aspose::Words", "Aspose::Words::Field"}, new []{10, 30});
                using (LookupFrame namespace1Frame = rootFrame.EnterChild("Aspose::Words"))
                {
                    namespace1Frame.AppendKnownChildren(new[] {"Node"});
                    CheckWeights(namespace1Frame, new []{"Node"}, new []{20});
                }
                using (LookupFrame namespace2Frame = rootFrame.EnterChild("Aspose::Words::Field"))
                {
                    namespace2Frame.AppendKnownChildren(new[] {"Field", "FieldChar"});
                    CheckWeights(namespace2Frame, new []{"Field", "FieldChar"}, new []{10, 20});
                }
            }
            LookupData expected = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10, new []{new LookupItem("Node", 20)}),
                    new LookupItem("Aspose::Words::Field", 30, new []{new LookupItem("Field", 10), new LookupItem("FieldChar", 20)})
                });
            LookupDataChecker.Check(expected, lookupManager.GetDestData());
        }

        [Test]
        public void GenerateForAddRemoveSourceInDest()
        {
            LookupData source = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10, new []{new LookupItem("Body", 10), new LookupItem("Node", 20)}),
                    new LookupItem("Aspose::Words::BuildingBlocks", 20),
                    new LookupItem("Aspose::Words::Field", 30, new []{new LookupItem("Field", 10), new LookupItem("FieldChar", 20), new LookupItem("FieldIf", 30)})
                });
            LookupManager lookupManager = new LookupManager(source);
            using (LookupFrame rootFrame = lookupManager.EnterRootFrame())
            {
                rootFrame.AppendKnownChildren(new[] {"Aspose::Words", "Aspose::Words::Comparing", "Aspose::Words::Drawing", "Aspose::Words::Field"});
                CheckWeights(rootFrame, new []{"Aspose::Words", "Aspose::Words::Comparing", "Aspose::Words::Drawing", "Aspose::Words::Field"}, new []{10, 17, 24, 30});
                using (LookupFrame namespace1Frame = rootFrame.EnterChild("Aspose::Words"))
                {
                    namespace1Frame.AppendKnownChildren(new[] {"Body", "Font", "Story"});
                    CheckWeights(namespace1Frame, new []{"Body", "Font", "Story"}, new []{10, 20, 30});
                }
                using (LookupFrame namespace2Frame = rootFrame.EnterChild("Aspose::Words::Field"))
                {
                    namespace2Frame.AppendKnownChildren(new[] {"Field", "FieldDate", "FieldDde", "FieldEnd", "FieldIf"});
                    CheckWeights(namespace2Frame, new []{"Field", "FieldDate", "FieldDde", "FieldEnd", "FieldIf"}, new []{10, 15, 20, 25, 30});
                }
            }
            LookupData expected = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10, new []{new LookupItem("Body", 10), new LookupItem("Font", 20), new LookupItem("Story", 30)}),
                    new LookupItem("Aspose::Words::Comparing", 17),
                    new LookupItem("Aspose::Words::Drawing", 24),
                    new LookupItem("Aspose::Words::Field", 30, new []
                    {
                        new LookupItem("Field", 10),
                        new LookupItem("FieldDate", 15),
                        new LookupItem("FieldDde", 20),
                        new LookupItem("FieldEnd", 25),
                        new LookupItem("FieldIf", 30)
                    })
                });
            LookupDataChecker.Check(expected, lookupManager.GetDestData());
        }

        [Test]
        public void GenerateForAddWithShiftSourceInDest()
        {
            LookupData source = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10),
                    new LookupItem("Aspose::Words::Field", 20, new []
                    {
                        new LookupItem("Field", 10),
                        new LookupItem("FieldChar", 11),
                        new LookupItem("FieldIf", 20),
                        new LookupItem("FieldInfo", 21),
                        new LookupItem("FieldNext", 22)
                    })
                });
            LookupManager lookupManager = new LookupManager(source);
            using (LookupFrame rootFrame = lookupManager.EnterRootFrame())
            {
                rootFrame.AppendKnownChildren(new[] {"Aspose::Words", "Aspose::Words::Field"});
                CheckWeights(rootFrame, new []{"Aspose::Words", "Aspose::Words::Field"}, new []{10, 20});
                using (LookupFrame namespaceFrame = rootFrame.EnterChild("Aspose::Words::Field"))
                {
                    namespaceFrame.AppendKnownChildren(new[] {"Field", "FieldAsk", "FieldChar", "FieldDate", "FieldIf", "FieldIndex", "FieldInfo", "FieldLink", "FieldNext"});
                    CheckWeights(namespaceFrame,
                                 new[]{"Field", "FieldAsk", "FieldChar", "FieldDate", "FieldIf", "FieldIndex", "FieldInfo", "FieldLink", "FieldNext"},
                                 new[] {10, 13, 16, 18, 20, 30, 40, 50, 60});
                }
            }
            LookupData expected = new LookupData(10,
                new[]
                {
                    new LookupItem("Aspose::Words", 10),
                    new LookupItem("Aspose::Words::Field", 20, new []
                    {
                        new LookupItem("Field", 10),
                        new LookupItem("FieldAsk", 13),
                        new LookupItem("FieldChar", 16),
                        new LookupItem("FieldDate", 18),
                        new LookupItem("FieldIf", 20),
                        new LookupItem("FieldIndex", 30),
                        new LookupItem("FieldInfo", 40),
                        new LookupItem("FieldLink", 50),
                        new LookupItem("FieldNext", 60)
                    })
                });
            LookupDataChecker.Check(expected, lookupManager.GetDestData());
        }

        private void CheckWeights(LookupFrame frame, String[] names, Int32[] weights)
        {
            for (Int32 index = 0; index < names.Length; ++index)
                Assert.AreEqual(weights[index], frame.GetChildWeight(names[index]));
        }
    }
}
