
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.PageInstrumentation
{
    public class PageImpressionClientMock : PageImpressionClient
    {


        public override System.String BasePageCorrelationId => BasePageCorrelationIdEx;
        public System.String BasePageCorrelationIdEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> ClientIdToClickInfoMap => ClientIdToClickInfoMapEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> ClientIdToClickInfoMapEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

