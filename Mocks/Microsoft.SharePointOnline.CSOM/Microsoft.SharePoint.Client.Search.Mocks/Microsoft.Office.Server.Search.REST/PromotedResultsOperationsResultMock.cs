
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Server.Search.REST
{
    public class PromotedResultsOperationsResultMock : PromotedResultsOperationsResult
    {


        public override System.Collections.Generic.IList<Microsoft.Office.Server.Search.REST.PromotedResultQueryRule> Result => ResultEx;
        public System.Collections.Generic.IList<Microsoft.Office.Server.Search.REST.PromotedResultQueryRule> ResultEx { get; set; }

        public override Microsoft.Office.Server.Search.REST.SearchObjectOwnerResult SearchObjectOwner => SearchObjectOwnerEx;
        public Microsoft.Office.Server.Search.REST.SearchObjectOwnerResult SearchObjectOwnerEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

