using System.Xml.Linq;
using Doxygen2HugoConverter.Markup;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter.Entities;

using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;

internal static class NamespaceParser
{
    public static EntityDef.NamespaceEntity ParseNamespaceFile(this NamespaceRef namespaceRef, ConvertData convertData)
    {
        XDocument document = XDocument.Load(Path.Combine( convertData.ConfigData.SourceDirectory, namespaceRef.RefId + Common.SourceFileExtension));
        ParseState state = new ParseState("", "", convertData);
        return document.Root!.Elements("compounddef").Single().ParseNamespaceEntity(state);
    }

    private static EntityDef.NamespaceEntity ParseNamespaceEntity(this XElement source, ParseState state)
    {
        String id = source.GetAttributeValue("id");
        String name = source.GetChildElementValue("compoundname");
        IList<SimpleMarkupEntry> briefDescription = source.ParseBriefDescription();
        IList<DetailedDescriptionMarkupEntry> detailedDescription = source.ParseDetailedDescriptionForNamespace();
        ParseState currentState = state with {ParentId = id, ParentName = name};
        IList<EntityDef.ClassEntity> classEntitySources = source.Elements("innerclass")
            .SelectMany(element => element.ParseClassEntities(currentState))
            .ToList();
        IList<EntityDef.ClassEntity> classEntities = classEntitySources.Where(entity => entity.Kind == ClassKind.Class).ToList();
        IList<EntityDef.ClassEntity> interfaceEntities = classEntitySources.Where(entity => entity.Kind == ClassKind.Interface).ToList();
        IList<EntityDef.EnumEntity> enumEntities = source.ParseEnumEntities(currentState).ToList();
        IList<EntityDef.TypedefEntity> typedefEntities = source.ParseTypedefEntities(currentState).ToList();
        EntityDef.NamespaceEntity result = new EntityDef.NamespaceEntity(id,
            name,
            briefDescription,
            detailedDescription,
            enumEntities,
            typedefEntities,
            classEntities,
            interfaceEntities);
        currentState.ConvertData.EntityRepo.Add(id, result);
        return result;
    }

    private static IEnumerable<EntityDef.ClassEntity> ParseClassEntities(this XElement source, ParseState state)
    {
        switch (source.GetAttributeValue("prot"))
        {
            case "public":
                String refId = source.GetAttributeValue("refid");
                XDocument document = XDocument.Load(Path.Combine(state.ConvertData.ConfigData.SourceDirectory, refId + Common.SourceFileExtension));
                return document.Root!.Elements("compounddef").Select(element => element.ParseClassEntity(state)).Choose();
            default:
                return Enumerable.Empty<EntityDef.ClassEntity>();

        }
    }

    private static IEnumerable<EntityDef.EnumEntity> ParseEnumEntities(this XElement source, ParseState state)
    {
        return source.Elements("sectiondef")
            .Where(element => element.GetAttributeValue("kind") == "enum")
            .SelectMany(section => section.Elements("memberdef").Choose(def => def.ParseEnumEntity(state)));
    }

    private static IEnumerable<EntityDef.TypedefEntity> ParseTypedefEntities(this XElement source, ParseState state)
    {
        return source.Elements("sectiondef")
            .Where(element => element.GetAttributeValue("kind") == "typedef")
            .SelectMany(section => section.Elements("memberdef").Choose(def => def.ParseTypedefEntity(state)));
    }

    private static DetailedDescriptionPortion ParseDetailedDescriptionForNamespace(this XElement source) =>
        source.Element("detaileddescription")!.ParseDetailedDescription();
}