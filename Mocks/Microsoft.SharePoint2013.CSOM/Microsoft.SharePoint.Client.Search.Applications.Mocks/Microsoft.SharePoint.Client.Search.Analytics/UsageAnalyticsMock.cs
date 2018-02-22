
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Analytics
{
    public class UsageAnalyticsMock : UsageAnalytics
    {


        public override Microsoft.SharePoint.Client.Search.Analytics.AnalyticsItemData GetAnalyticsItemData(System.Int32 @eventType, Microsoft.SharePoint.Client.ListItem @listItem)
        {
            return GetAnalyticsItemDataEx;
        }
        public Microsoft.SharePoint.Client.Search.Analytics.AnalyticsItemData GetAnalyticsItemDataEx { get; set;}

        public override Microsoft.SharePoint.Client.Search.Analytics.AnalyticsItemData GetAnalyticsItemDataForApplicationEventType(System.Guid @appEventType, Microsoft.SharePoint.Client.ListItem @listItem)
        {
            return GetAnalyticsItemDataForApplicationEventTypeEx;
        }
        public Microsoft.SharePoint.Client.Search.Analytics.AnalyticsItemData GetAnalyticsItemDataForApplicationEventTypeEx { get; set;}

        public override void DeleteStandardEventUsageData(System.Int32 @eventType)
        {
        }

        public override void DeleteCustomEventUsageData(System.Guid @appEventTypeId)
        {
        }

    }
}

