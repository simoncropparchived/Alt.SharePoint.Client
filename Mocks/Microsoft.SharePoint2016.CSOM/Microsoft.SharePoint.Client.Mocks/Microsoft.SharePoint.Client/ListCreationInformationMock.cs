
namespace Microsoft.SharePoint.Client
{
    public class ListCreationInformationMock
    {


        public override System.String CustomSchemaXml => CustomSchemaXmlEx;
        public System.String CustomSchemaXmlEx { get; set; }

        public override System.Collections.Generic.IDictionary`2<System.String,System.String> DataSourceProperties => DataSourcePropertiesEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.String> DataSourcePropertiesEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Int32 DocumentTemplateType => DocumentTemplateTypeEx;
        public System.Int32 DocumentTemplateTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.QuickLaunchOptions QuickLaunchOption => QuickLaunchOptionEx;
        public Microsoft.SharePoint.Client.QuickLaunchOptions QuickLaunchOptionEx { get; set; }

        public override System.Guid TemplateFeatureId => TemplateFeatureIdEx;
        public System.Guid TemplateFeatureIdEx { get; set; }

        public override System.Int32 TemplateType => TemplateTypeEx;
        public System.Int32 TemplateTypeEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

