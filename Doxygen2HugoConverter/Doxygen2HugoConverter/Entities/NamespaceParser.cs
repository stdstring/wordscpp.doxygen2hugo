using System.Xml.Linq;
using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Markup;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter.Entities;

internal static class NamespaceParser
{
    public static EntityDef.NamespaceEntity ParseNamespaceFile(ConfigData config, IDictionary<String, EntityDef> commonEntityRepo, NamespaceRef namespaceRef)
    {
        XDocument document = XDocument.Load(Path.Combine(config.SourceDirectory, namespaceRef.RefId + Common.SourceFileExtension));
        ParseState state = new ParseState("", "", commonEntityRepo);
        return ParseNamespaceEntity(config, state, document.Root!.Elements("compounddef").Single());
    }

    private static EntityDef.NamespaceEntity ParseNamespaceEntity(ConfigData config, ParseState state, XElement source)
    {
        String id = source.GetAttributeValue("id");
        String name = source.GetChildElementValue("compoundname");
        IList<SimpleMarkupEntry> briefDescription = ParserUtils.ParseBriefDescription(source);
        IList<DetailedDescriptionMarkupEntry> detailedDescription = ParseNamespaceDetailedDescription(source);
        ParseState currentState = state with {ParentId = id, ParentName = name};
        IList<EntityDef.ClassEntity> classEntitySources = source.Elements("innerclass")
            .SelectMany(element => ParseClassEntities(config, currentState, element))
            .ToList();
        IList<EntityDef.ClassEntity> classEntities = classEntitySources.Where(entity => entity.Kind == ClassKind.Class).ToList();
        IList<EntityDef.ClassEntity> interfaceEntities = classEntitySources.Where(entity => entity.Kind == ClassKind.Interface).ToList();
        IList<EntityDef.EnumEntity> enumEntities = ParseEnumEntities(currentState, source).ToList();
        IList<EntityDef.TypedefEntity> typedefEntities = ParseTypedefEntities(currentState, source).ToList();
        EntityDef.NamespaceEntity result = new EntityDef.NamespaceEntity(id,
            name,
            briefDescription,
            detailedDescription,
            enumEntities,
            typedefEntities,
            classEntities,
            interfaceEntities);
        currentState.CommonEntityRepo.Add(id, result);
        return result;
    }

    private static IEnumerable<EntityDef.ClassEntity> ParseClassEntities(ConfigData config, ParseState state, XElement source)
    {
        switch (source.GetAttributeValue("prot"))
        {
            case "public":
                String refId = source.GetAttributeValue("refid");
                XDocument document = XDocument.Load(Path.Combine(config.SourceDirectory, refId + Common.SourceFileExtension));
                return document.Root!.Elements("compounddef").Select(element => ClassParser.Parse(state, element)).Choose();
            default:
                return Enumerable.Empty<EntityDef.ClassEntity>();

        }
    }

    private static IEnumerable<EntityDef.EnumEntity> ParseEnumEntities(ParseState state, XElement source)
    {
        return source.Elements("sectiondef")
            .Where(element => element.GetAttributeValue("kind") == "enum")
            .SelectMany(section => section.Elements("memberdef").Choose(def => EnumParser.Parse(state, def)));
    }

    private static IEnumerable<EntityDef.TypedefEntity> ParseTypedefEntities(ParseState state, XElement source)
    {
        return source.Elements("sectiondef")
            .Where(element => element.GetAttributeValue("kind") == "typedef")
            .SelectMany(section => section.Elements("memberdef").Choose(def => TypedefParser.Parse(state, def)));
    }

    private static IList<DetailedDescriptionMarkupEntry> ParseNamespaceDetailedDescription(XElement source) =>
        MarkupParser.ParseDetailedDescription(source.Element("detaileddescription")!);
}