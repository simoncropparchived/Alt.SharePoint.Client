
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Server.Search.REST
{
    public class QueryConfigurationMock : QueryConfiguration
    {


        public override Microsoft.Office.Server.Search.REST.QueryContext QueryContext => QueryContextEx;
        public Microsoft.Office.Server.Search.REST.QueryContext QueryContextEx { get; set; }

        public override Microsoft.Office.Server.Search.REST.ExpandedQueryParameters QueryParameters => QueryParametersEx;
        public Microsoft.Office.Server.Search.REST.ExpandedQueryParameters QueryParametersEx { get; set; }

        public override Microsoft.Office.Server.Search.REST.QueryRoutingInfo QueryRoutingInfo => QueryRoutingInfoEx;
        public Microsoft.Office.Server.Search.REST.QueryRoutingInfo QueryRoutingInfoEx { get; set; }

        public override Microsoft.Office.Server.Search.REST.SearchEndpoints SearchEndpoints => SearchEndpointsEx;
        public Microsoft.Office.Server.Search.REST.SearchEndpoints SearchEndpointsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

