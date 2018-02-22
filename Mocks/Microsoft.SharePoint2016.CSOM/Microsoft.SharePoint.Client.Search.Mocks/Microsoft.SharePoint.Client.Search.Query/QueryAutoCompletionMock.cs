
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QueryAutoCompletionMock : QueryAutoCompletion
    {


        public override System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.Search.Query.QueryAutoCompletionMatch> Matches => MatchesEx;
        public System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.Search.Query.QueryAutoCompletionMatch> MatchesEx { get; set; }

        public override System.String Query => QueryEx;
        public System.String QueryEx { get; set; }

        public override System.Double Score => ScoreEx;
        public System.Double ScoreEx { get; set; }

        public override System.String Source => SourceEx;
        public System.String SourceEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

