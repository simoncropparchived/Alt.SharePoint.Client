
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QuerySuggestionQueryMock : QuerySuggestionQuery
    {


        public override System.Boolean IsPersonal => IsPersonalEx;
        public System.Boolean IsPersonalEx { get; set; }

        public override System.String Query => QueryEx;
        public System.String QueryEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

