
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class FollowedContentMock : FollowedContent
    {


        public override System.String FollowedDocumentsUrl => FollowedDocumentsUrlEx;
        public System.String FollowedDocumentsUrlEx { get; set; }

        public override System.String FollowedSitesUrl => FollowedSitesUrlEx;
        public System.String FollowedSitesUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> HasGroupMembershipChangedAndSyncChanges()
        {
            return HasGroupMembershipChangedAndSyncChangesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> HasGroupMembershipChangedAndSyncChangesEx { get; set;}

        public override void UpdateFollowedGroupForUser(System.String @contextUri, System.Guid @groupId, System.String @loginName)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowResult> Follow(System.String @url, Microsoft.SharePoint.Client.UserProfiles.FollowedItemData @data)
        {
            return FollowEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowResult> FollowEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowResult> SetItemPinState(System.String @uri, System.Guid @groupId, System.Int32 @pinState)
        {
            return SetItemPinStateEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowResult> SetItemPinStateEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowResult> FollowItem(Microsoft.SharePoint.Client.UserProfiles.FollowedItem @item)
        {
            return FollowItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowResult> FollowItemEx { get; set;}

        public override void StopFollowing(System.String @url)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsFollowed(System.String @url)
        {
            return IsFollowedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsFollowedEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedStatus> GetFollowedStatus(System.String @url)
        {
            return GetFollowedStatusEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedStatus> GetFollowedStatusEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> GetItem(System.String @url)
        {
            return GetItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> GetItemEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem[]> GetItems(Microsoft.SharePoint.Client.UserProfiles.FollowedContentQueryOptions @options, System.Int32 @subtype)
        {
            return GetItemsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem[]> GetItemsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem[]> GetGroups(System.Int32 @rowLimit)
        {
            return GetGroupsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem[]> GetGroupsEx { get; set;}

        public override void UpdateData(System.String @url, Microsoft.SharePoint.Client.UserProfiles.FollowedItemData @data)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> RefreshFollowedItem(Microsoft.SharePoint.Client.UserProfiles.FollowedItem @item)
        {
            return RefreshFollowedItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> RefreshFollowedItemEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> FindAndUpdateFollowedGroup(System.Guid @groupId)
        {
            return FindAndUpdateFollowedGroupEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> FindAndUpdateFollowedGroupEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> FindAndUpdateFollowedItem(System.String @url)
        {
            return FindAndUpdateFollowedItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.FollowedItem> FindAndUpdateFollowedItemEx { get; set;}

    }
}

