
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteListEventPropertiesMock
    {


        public override System.String WebUrl => WebUrlEx;
        public System.String WebUrlEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.String ListTitle => ListTitleEx;
        public System.String ListTitleEx { get; set; }

        public override System.String FieldName => FieldNameEx;
        public System.String FieldNameEx { get; set; }

        public override System.String FieldXml => FieldXmlEx;
        public System.String FieldXmlEx { get; set; }

        public override System.Int32 TemplateId => TemplateIdEx;
        public System.Int32 TemplateIdEx { get; set; }

        public override System.Guid FeatureId => FeatureIdEx;
        public System.Guid FeatureIdEx { get; set; }

    }
}

