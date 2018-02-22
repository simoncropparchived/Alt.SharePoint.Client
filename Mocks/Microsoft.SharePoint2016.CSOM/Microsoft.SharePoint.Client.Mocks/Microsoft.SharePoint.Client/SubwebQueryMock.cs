
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class SubwebQueryMock : SubwebQuery
    {


        public override System.Int32 ConfigurationFilter => ConfigurationFilterEx;
        public System.Int32 ConfigurationFilterEx { get; set; }

        public override System.Int32 WebTemplateFilter => WebTemplateFilterEx;
        public System.Int32 WebTemplateFilterEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

