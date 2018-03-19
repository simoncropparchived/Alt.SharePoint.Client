
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedStoreMock : MicrofeedStore
    {


        public override void AddData(System.String @name, System.Byte[] @data)
        {
        }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedData GetItem(System.String @storeIdentifier)
        {
            return GetItemEx;
        }
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedData GetItemEx { get; set;}

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedData NewItem(System.String @storeIdentifier)
        {
            return NewItemEx;
        }
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedData NewItemEx { get; set;}

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedDataCollection Query(System.String @storeIdentifier, Microsoft.SharePoint.Client.Microfeed.MicrofeedDataQuery @query)
        {
            return QueryEx;
        }
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedDataCollection QueryEx { get; set;}

        public override void ExecutePendingOperations()
        {
        }

        public override void IncrementUnreadAtMentionCount(System.String @accountName)
        {
        }

        public override void SetPostLikeStatus(System.String @accountName, System.String @postId, System.Boolean @like)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetSocialProperties(System.String @accountName)
        {
            return GetSocialPropertiesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetSocialPropertiesEx { get; set;}

    }
}

