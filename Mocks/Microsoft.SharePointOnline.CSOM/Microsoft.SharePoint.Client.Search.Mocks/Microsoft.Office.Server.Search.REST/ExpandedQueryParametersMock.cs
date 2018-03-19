
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Server.Search.REST
{
    public class ExpandedQueryParametersMock : ExpandedQueryParameters
    {


        public override System.Collections.Generic.IDictionary<System.String, System.Object> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary<System.String, System.Object> PropertiesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

