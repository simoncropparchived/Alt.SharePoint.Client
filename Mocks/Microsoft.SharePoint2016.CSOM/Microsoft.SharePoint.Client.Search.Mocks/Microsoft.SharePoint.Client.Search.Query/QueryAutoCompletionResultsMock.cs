
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QueryAutoCompletionResultsMock : QueryAutoCompletionResults
    {


        public override System.Int64 CoreExecutionTimeMs => CoreExecutionTimeMsEx;
        public System.Int64 CoreExecutionTimeMsEx { get; set; }

        public override System.String CorrelationId => CorrelationIdEx;
        public System.String CorrelationIdEx { get; set; }

        public override System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.Search.Query.QueryAutoCompletion> Queries => QueriesEx;
        public System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.Search.Query.QueryAutoCompletion> QueriesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}
