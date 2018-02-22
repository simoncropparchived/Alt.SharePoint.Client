
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Analytics
{
    public class AnalyticsItemDataMock : AnalyticsItemData
    {


        public override System.DateTime LastProcessingTime => LastProcessingTimeEx;
        public System.DateTime LastProcessingTimeEx { get; set; }

        public override System.Int32 TotalHits => TotalHitsEx;
        public System.Int32 TotalHitsEx { get; set; }

        public override System.Int32 TotalUniqueUsers => TotalUniqueUsersEx;
        public System.Int32 TotalUniqueUsersEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetHitCountForDay(System.DateTime @day)
        {
            return GetHitCountForDayEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetHitCountForDayEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUniqueUsersCountForDay(System.DateTime @day)
        {
            return GetUniqueUsersCountForDayEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUniqueUsersCountForDayEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetHitCountForMonth(System.DateTime @month)
        {
            return GetHitCountForMonthEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetHitCountForMonthEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUniqueUsersCountForMonth(System.DateTime @month)
        {
            return GetUniqueUsersCountForMonthEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUniqueUsersCountForMonthEx { get; set;}

    }
}

