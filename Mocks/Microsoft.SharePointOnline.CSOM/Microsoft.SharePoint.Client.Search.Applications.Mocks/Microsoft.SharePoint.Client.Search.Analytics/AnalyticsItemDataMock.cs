
namespace Microsoft.SharePoint.Client.Search.Analytics
{
    public class AnalyticsItemDataMock
    {


        public override System.DateTime LastProcessingTime => LastProcessingTimeEx;
        public System.DateTime LastProcessingTimeEx { get; set; }

        public override System.Int32 TotalHits => TotalHitsEx;
        public System.Int32 TotalHitsEx { get; set; }

        public override System.Int32 TotalUniqueUsers => TotalUniqueUsersEx;
        public System.Int32 TotalUniqueUsersEx { get; set; }

    }
}

