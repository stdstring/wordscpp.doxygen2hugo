using System.Text;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Logger;
using Doxygen2HugoConverter.Markup;

namespace Doxygen2HugoConverter.Generator
{
    using TemplateParameters = IList<TemplateParameter>;

    internal record GenerateEntry(String Title, String BriefDescription);

    internal record GenerateState(String Directory, IList<String> Url, ConvertData ConvertData)
    {
        public Int32 Weight { get; private set; } = 1;

        public void IncreaseWeight()
        {
            Weight += WeightDelta;
        }

        private const Int32 WeightDelta = 13;
    }

    internal static class GeneratorUtils
    {
        public static String CreateDefaultHeaderDescription(this EntityDef entity, ConvertData convertData)
        {
            switch (entity)
            {
                case EntityDef.NamespaceEntity _:
                    return $"How to use {entity.Name} namespace";
                default:
                    EntityDef parent = convertData.EntityRepo[entity.ParentId];
                    return entity switch
                    {
                        EntityDef.ClassEntity {Kind: ClassKind.Class} classEntity => $"How to use {classEntity.FullName} class",
                        EntityDef.ClassEntity {Kind: ClassKind.Interface} classEntity => $"How to use {classEntity.FullName} interface",
                        EntityDef.EnumEntity enumEntity => $"How to use {enumEntity.FullName} enum",
                        EntityDef.FieldEntity fieldEntity => $"How to use {fieldEntity.Name} field of {parent.FullName} class",
                        EntityDef.MethodEntity {Kind: MethodKind.Constructor} methodEntity => $"How to use {methodEntity.Name} constructor of {parent.FullName} class",
                        EntityDef.MethodEntity {Kind: MethodKind.Method} methodEntity => $"How to use {methodEntity.Name} method of {parent.FullName} class",
                        EntityDef.TypedefEntity typedefEntity when parent.EntityKind == EntityKind.Namespace => $"How to use {typedefEntity.FullName} typedef",
                        EntityDef.TypedefEntity typedefEntity when parent.EntityKind == EntityKind.Class => $"How to use {typedefEntity.FullName} typedef of {parent.FullName} class",
                        _ => throw new InvalidOperationException("Unexpected entity")
                    };
            }
        }

        public static void GenerateDefPageHeader(String title, String linkTitle, String description, IList<String> url, Int32 weight, ConvertData convertData, StringBuilder dest)
        {
            const String urlRemovablePrefix = $"/{Common.RootDirectory}/";
            String refUrl = UrlGenerator.CreateUrl(url, false).TrimEnd('/');
            if (refUrl.StartsWith(urlRemovablePrefix))
                refUrl = refUrl.Substring(urlRemovablePrefix.Length);
            String pageHeader = convertData.PageHeaderGenerator(new Dictionary<String, String>
            {
                {"title", title},
                {"linktitle", linkTitle},
                {"description", description.TrimEnd('.')},
                {"weight", weight.ToString()},
                {"ref", refUrl}
            });
            dest.AppendLine(pageHeader);
        }

        public static void GenerateHeader(String headerText, Int32 headerLevel, StringBuilder dest)
        {
            StringBuilder header = new StringBuilder();
            header.Append(new String('#', headerLevel)).Append(' ').AppendLine(headerText).AppendLine();
            dest.Append(header.ToString());
        }

        public static void GenerateTableHeader(IList<String> columnHeaders, StringBuilder dest)
        {
            dest.Append("|");
            columnHeaders.Iterate(header => { dest.Append($" {header} |"); });
            dest.AppendLine();
            dest.Append("|");
            Enumerable.Range(1, columnHeaders.Count).Iterate(_ => { dest.Append(" --- |"); });
            dest.AppendLine();
        }

        public static void GenerateTemplateParameters(this TemplateParameters templateParameters, Func<String, String?> relativeUrlGenerator, StringBuilder dest, ILogger logger)
        {
            if (templateParameters.IsEmpty())
                return;
            dest.AppendLine();
            GenerateTableHeader(new[]{"Parameter", "Description"}, dest);
            foreach (TemplateParameter templateParameter in templateParameters)
            {
                String parameterDescription = templateParameter.Description.CreateSimpleMarkup(relativeUrlGenerator, logger);
                dest.AppendLine($"| {templateParameter.Name} | {parameterDescription} |");
            }
        }

        public static String CreateLink(String name, String url) => $"[{name}]({url})";

        public static void GenerateSeeAlsoEntry(this EntityDef definition, String url, StringBuilder dest)
        {
            switch (definition)
            {
                case EntityDef.NamespaceEntity entity:
                    dest.AppendLine($"* Namespace {CreateLink(entity.Name, url)}");
                    return;
                case EntityDef.ClassEntity {Kind: ClassKind.Class} entity:
                    dest.AppendLine($"* Class {CreateLink(entity.Name, url)}");
                    return;
                case EntityDef.ClassEntity {Kind: ClassKind.Interface} entity:
                    dest.AppendLine($"* Interface {CreateLink(entity.Name, url)}");
                    return;
                case EntityDef.EnumEntity entity:
                    dest.AppendLine($"* Enum {CreateLink(entity.Name, url)}");
                    return;
                case EntityDef.TypedefEntity entity:
                    dest.AppendLine($"* Typedef {CreateLink(entity.Name, url)}");
                    return;
                //case EntityDef.MethodEntity entity:
                //    return;
                //case EntityDef.FieldEntity entity:
                //    return;
            }
        }

        public static void GenerateSeeAlsoCommonPart(this EntityDef definition, IDictionary<String, EntityDef> entityRepo, ConvertData convertData, StringBuilder dest)
        {
            IList<EntityDef> CreateParentList()
            {
                IList<EntityDef> parentList = new List<EntityDef>();
                EntityDef? current = definition;
                while (current != null)
                {
                    switch (current)
                    {
                        case EntityDef.NamespaceEntity:
                            current = null;
                            break;
                        case EntityDef.ClassEntity entity:
                            parentList.Add(current = entityRepo[entity.ParentId]);
                            break;
                        case EntityDef.MethodEntity entity:
                            parentList.Add(current = entityRepo[entity.ParentId]);
                            break;
                        case EntityDef.FieldEntity entity:
                            parentList.Add(current = entityRepo[entity.ParentId]);
                            break;
                        case EntityDef.EnumEntity entity:
                            parentList.Add(current = entityRepo[entity.ParentId]);
                            break;
                        case EntityDef.TypedefEntity entity:
                            parentList.Add(current = entityRepo[entity.ParentId]);
                            break;
                    }
                }
                return parentList;
            }
            StringBuilder parentUrl = new StringBuilder();
            IList<EntityDef> parentList = CreateParentList();
            foreach (EntityDef parent in parentList)
            {
                parentUrl.Append(Common.ParentUrl);
                parent.GenerateSeeAlsoEntry(parentUrl.ToString(), dest);
            }
            parentUrl.Append(Common.ParentUrl);
            dest.AppendLine($"* Library {CreateLink(convertData.LibraryName, parentUrl.ToString())}");
        }
    }
}
