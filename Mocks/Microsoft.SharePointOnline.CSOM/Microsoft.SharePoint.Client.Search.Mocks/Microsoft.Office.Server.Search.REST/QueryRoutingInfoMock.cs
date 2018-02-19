
namespace Microsoft.Office.Server.Search.REST
{
    public class QueryRoutingInfoMock : QueryRoutingInfo
    {


        public override Microsoft.Office.Server.Search.REST.QueryState QueryState => QueryStateEx;
        public Microsoft.Office.Server.Search.REST.QueryState QueryStateEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.Office.Server.Search.REST.SearchEndpoints> SearchEndpoints => SearchEndpointsEx;
        public System.Collections.Generic.IList<Microsoft.Office.Server.Search.REST.SearchEndpoints> SearchEndpointsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

