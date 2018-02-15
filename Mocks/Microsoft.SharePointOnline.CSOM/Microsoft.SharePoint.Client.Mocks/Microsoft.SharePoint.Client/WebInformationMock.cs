
namespace Microsoft.SharePoint.Client
{
    public class WebInformationMock
    {


        public override System.Int16 Configuration => ConfigurationEx;
        public System.Int16 ConfigurationEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.UInt32 Language => LanguageEx;
        public System.UInt32 LanguageEx { get; set; }

        public override System.DateTime LastItemModifiedDate => LastItemModifiedDateEx;
        public System.DateTime LastItemModifiedDateEx { get; set; }

        public override System.DateTime LastItemUserModifiedDate => LastItemUserModifiedDateEx;
        public System.DateTime LastItemUserModifiedDateEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String WebTemplate => WebTemplateEx;
        public System.String WebTemplateEx { get; set; }

        public override System.Int32 WebTemplateId => WebTemplateIdEx;
        public System.Int32 WebTemplateIdEx { get; set; }

    }
}

