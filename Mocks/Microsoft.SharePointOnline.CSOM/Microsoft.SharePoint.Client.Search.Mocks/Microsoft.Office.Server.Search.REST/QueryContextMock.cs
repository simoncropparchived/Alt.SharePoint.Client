
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Server.Search.REST
{
    public class QueryContextMock : QueryContext
    {


        public override System.String PortalUrl => PortalUrlEx;
        public System.String PortalUrlEx { get; set; }

        public override System.Guid SpSiteId => SpSiteIdEx;
        public System.Guid SpSiteIdEx { get; set; }

        public override System.Guid SpWebId => SpWebIdEx;
        public System.Guid SpWebIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

