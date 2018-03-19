
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Server.Search.REST
{
    public class SearchEndpointsMock : SearchEndpoints
    {


        public override System.String AdminEndpoint => AdminEndpointEx;
        public System.String AdminEndpointEx { get; set; }

        public override System.String AfdEndpoint => AfdEndpointEx;
        public System.String AfdEndpointEx { get; set; }

        public override System.String Geolocation => GeolocationEx;
        public System.String GeolocationEx { get; set; }

        public override Microsoft.Office.Server.Search.REST.QueryContext QueryContext => QueryContextEx;
        public Microsoft.Office.Server.Search.REST.QueryContext QueryContextEx { get; set; }

        public override System.String QueryEndpoint => QueryEndpointEx;
        public System.String QueryEndpointEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

