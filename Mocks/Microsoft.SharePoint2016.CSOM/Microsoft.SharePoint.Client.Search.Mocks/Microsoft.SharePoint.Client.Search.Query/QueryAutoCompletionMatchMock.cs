
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QueryAutoCompletionMatchMock : QueryAutoCompletionMatch
    {


        public override System.Boolean Alternation => AlternationEx;
        public System.Boolean AlternationEx { get; set; }

        public override System.String Key => KeyEx;
        public System.String KeyEx { get; set; }

        public override System.Int64 Length => LengthEx;
        public System.Int64 LengthEx { get; set; }

        public override System.String MatchType => MatchTypeEx;
        public System.String MatchTypeEx { get; set; }

        public override System.Double Score => ScoreEx;
        public System.Double ScoreEx { get; set; }

        public override System.String SourceName => SourceNameEx;
        public System.String SourceNameEx { get; set; }

        public override System.Int64 Start => StartEx;
        public System.Int64 StartEx { get; set; }

        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

