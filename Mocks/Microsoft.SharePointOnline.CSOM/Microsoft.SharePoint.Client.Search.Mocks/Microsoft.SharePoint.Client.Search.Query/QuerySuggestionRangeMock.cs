
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class QuerySuggestionRangeMock : QuerySuggestionRange
    {


        public override System.Int32 Length => LengthEx;
        public System.Int32 LengthEx { get; set; }

        public override System.Int32 Start => StartEx;
        public System.Int32 StartEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

