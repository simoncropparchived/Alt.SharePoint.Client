
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class MicroServiceWorkItemPropertiesMock : MicroServiceWorkItemProperties
    {


        public override System.String ApiPath => ApiPathEx;
        public System.String ApiPathEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String, System.Object> CustomProperties => CustomPropertiesEx;
        public System.Collections.Generic.IDictionary<System.String, System.Object> CustomPropertiesEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String, System.String> HttpHeaders => HttpHeadersEx;
        public System.Collections.Generic.IDictionary<System.String, System.String> HttpHeadersEx { get; set; }

        public override System.String MicroServiceName => MicroServiceNameEx;
        public System.String MicroServiceNameEx { get; set; }

        public override Microsoft.SharePoint.Client.RequestType RequestType => RequestTypeEx;
        public Microsoft.SharePoint.Client.RequestType RequestTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

