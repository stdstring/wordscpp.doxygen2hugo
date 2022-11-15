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

    internal record BaseClassEntity(String Access, Boolean Virtual, String QualifiedName);

    internal abstract record EntityDef
    {
        internal record EnumEntity(String Id,
                                   String ParentId,
                                   String Name,
                                   String QualifiedName,
                                   String BaseType,
                                   SimpleMarkupPortion BriefDescription,
                                   DetailedDescriptionPortion DetailedDescription,
                                   IList<EnumValueEntity> Values) : EntityDef;

        internal record TypedefEntity(String Id,
                                      String ParentId,
                                      String Name,
                                      String QualifiedName,
                                      String SourceType,
                                      String Definition,
                                      SimpleMarkupPortion BriefDescription,
                                      DetailedDescriptionPortion DetailedDescription) : EntityDef;

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
                                    DetailedDescriptionPortion DetailedDescription) : EntityDef;

        internal record MethodEntity(String Id,
                                     String ParentId,
                                     String Name,
                                     String ClassName,
                                     Boolean IsStatic,
                                     Boolean IsConst,
                                     Boolean IsExplicit,
                                     Boolean IsVirtual,
                                     Boolean IsOverride,
                                     SimpleMarkupPortion BriefDescription,
                                     MethodDetailedDescription DetailedDescription,
                                     String Definition,
                                     String ArgString,
                                     IList<String> TemplateParameters,
                                     IList<MethodArgEntity> Args,
                                     SimpleMarkupPortion ReturnType) : EntityDef;

        internal record MethodGroupEntity(String Name, IList<MethodEntity> Methods) : EntityDef;

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
                                    IList<MemberRef> MemberRefs) : EntityDef;

        internal record NamespaceEntity(String Id,
                                        String Name,
                                        SimpleMarkupPortion BriefDescription,
                                        DetailedDescriptionPortion DetailedDescription,
                                        IList<EnumEntity> Enums,
                                        IList<TypedefEntity> Typedefs,
                                        IList<ClassEntity> Classes,
                                        IList<ClassEntity> Interfaces) : EntityDef;

        private EntityDef()
        {
        }
    };
}
