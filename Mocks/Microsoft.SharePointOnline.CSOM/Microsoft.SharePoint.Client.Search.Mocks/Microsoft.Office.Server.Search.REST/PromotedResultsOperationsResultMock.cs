
namespace Microsoft.Office.Server.Search.REST
{
    public class PromotedResultsOperationsResultMock
    {


        public override System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.PromotedResultQueryRule> Result => ResultEx;
        public System.Collections.Generic.IList`1<Microsoft.Office.Server.Search.REST.PromotedResultQueryRule> ResultEx { get; set; }

        public override Microsoft.Office.Server.Search.REST.SearchObjectOwnerResult SearchObjectOwner => SearchObjectOwnerEx;
        public Microsoft.Office.Server.Search.REST.SearchObjectOwnerResult SearchObjectOwnerEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

