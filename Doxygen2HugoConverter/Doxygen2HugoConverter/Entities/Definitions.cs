using Doxygen2HugoConverter.Markup;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter.Entities
{
    using SimpleMarkupPortion = IList<SimpleMarkupEntry>;
    using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;

    internal record EnumValueEntity(String Id, String Name, Int32? Initializer, SimpleMarkupPortion BriefDescription);

    internal record MethodArgEntity(String Name, SimpleMarkupPortion Type);

    internal enum ClassKind
    {
        Class,
        Interface
    }

    internal enum MethodKind
    {
        Constructor,
        Method
    }

    internal record BaseClassEntity(String? RefId, String Access, Boolean Virtual, String QualifiedName);

    internal record MethodGroupEntity(String Name, IList<EntityDef.MethodEntity> Methods);

    internal enum EntityKind
    {
        Enum,
        Typedef,
        Field,
        Method,
        Class,
        Namespace
    }

    internal abstract record EntityDef(String Id, String ParentId, String Name, String FullName, EntityKind EntityKind)
    {
        internal record EnumEntity(String Id,
                                   String ParentId,
                                   String Name,
                                   String FullName,
                                   String? BaseType,
                                   SimpleMarkupPortion BriefDescription,
                                   DetailedDescriptionPortion DetailedDescription,
                                   IList<EnumValueEntity> Values) : EntityDef(Id, ParentId, Name, FullName, EntityKind.Enum);

        internal record TypedefEntity(String Id,
                                      String ParentId,
                                      String Name,
                                      String FullName,
                                      String SourceType,
                                      String Definition,
                                      SimpleMarkupPortion BriefDescription,
                                      DetailedDescriptionPortion DetailedDescription) : EntityDef(Id, ParentId, Name, FullName, EntityKind.Typedef);

        internal record FieldEntity(String Id,
                                    String ParentId,
                                    Boolean IsStatic,
                                    Boolean IsConstexpr,
                                    Boolean IsMutable,
                                    String Name,
                                    String FullName,
                                    String Type,
                                    String Definition,
                                    String? Initializer,
                                    SimpleMarkupPortion BriefDescription,
                                    DetailedDescriptionPortion DetailedDescription) : EntityDef(Id, ParentId, Name, FullName, EntityKind.Field);

        internal record MethodEntity(String Id,
                                     String ParentId,
                                     String Name,
                                     String ClassName,
                                     String FullName,
                                     Boolean IsStatic,
                                     Boolean IsConst,
                                     Boolean IsExplicit,
                                     Boolean IsVirtual,
                                     Boolean IsOverride,
                                     MethodKind Kind,
                                     SimpleMarkupPortion BriefDescription,
                                     MethodDetailedDescription DetailedDescription,
                                     String Definition,
                                     String ArgString,
                                     IList<String> TemplateParameters,
                                     IList<MethodArgEntity> Args,
                                     SimpleMarkupPortion ReturnType) : EntityDef(Id, ParentId, Name, FullName, EntityKind.Method);

        internal record ClassEntity(String Id,
                                    String ParentId,
                                    String Name,
                                    String FullName,
                                    Boolean Final,
                                    ClassKind Kind,
                                    SimpleMarkupPortion BriefDescription,
                                    ClassDetailedDescription DetailedDescription,
                                    IList<BaseClassEntity> BaseClasses,
                                    IList<String> TemplateParameters,
                                    IList<MethodGroupEntity> DirectMethods,
                                    IList<FieldEntity> Fields,
                                    IList<TypedefEntity> Typedefs,
                                    IList<MemberRef> MemberRefs) : EntityDef(Id, ParentId, Name, FullName, EntityKind.Class);

        internal record NamespaceEntity(String Id,
                                        String Name,
                                        SimpleMarkupPortion BriefDescription,
                                        DetailedDescriptionPortion DetailedDescription,
                                        IList<EnumEntity> Enums,
                                        IList<TypedefEntity> Typedefs,
                                        IList<ClassEntity> Classes,
                                        IList<ClassEntity> Interfaces) : EntityDef(Id, String.Empty, Name, String.Empty, EntityKind.Namespace)
        {
            public Boolean IsEmpty() => Enums.IsEmpty() && Typedefs.IsEmpty() && Classes.IsEmpty() && Interfaces.IsEmpty();
        }
    }
}
