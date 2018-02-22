
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListTemplateMock : ListTemplate
    {


        public override System.Boolean AllowsFolderCreation => AllowsFolderCreationEx;
        public System.Boolean AllowsFolderCreationEx { get; set; }

        public override Microsoft.SharePoint.Client.BaseType BaseType => BaseTypeEx;
        public Microsoft.SharePoint.Client.BaseType BaseTypeEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid FeatureId => FeatureIdEx;
        public System.Guid FeatureIdEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.String ImageUrl => ImageUrlEx;
        public System.String ImageUrlEx { get; set; }

        public override System.String InternalName => InternalNameEx;
        public System.String InternalNameEx { get; set; }

        public override System.Boolean IsCustomTemplate => IsCustomTemplateEx;
        public System.Boolean IsCustomTemplateEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Boolean OnQuickLaunch => OnQuickLaunchEx;
        public System.Boolean OnQuickLaunchEx { get; set; }

        public override System.Int32 ListTemplateTypeKind => ListTemplateTypeKindEx;
        public System.Int32 ListTemplateTypeKindEx { get; set; }

        public override System.Boolean Unique => UniqueEx;
        public System.Boolean UniqueEx { get; set; }

    }
}

