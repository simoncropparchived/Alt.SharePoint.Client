
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedManagerMock : MicrofeedManager
    {


        public override Microsoft.SharePoint.Client.Microfeed.MicroBlogEntity CurrentUser => CurrentUserEx;
        public Microsoft.SharePoint.Client.Microfeed.MicroBlogEntity CurrentUserEx { get; set; }

        public override System.Boolean IsFeedActivityPublic => IsFeedActivityPublicEx;
        public System.Boolean IsFeedActivityPublicEx { get; set; }

        public override System.String StaticThreadLink => StaticThreadLinkEx;
        public System.String StaticThreadLinkEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> Post(Microsoft.SharePoint.Client.Microfeed.MicrofeedPostOptions @postOptions)
        {
            return PostEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> PostEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> PostReply(System.String @postIdentifier, Microsoft.SharePoint.Client.Microfeed.MicrofeedPostOptions @postReplyOptions)
        {
            return PostReplyEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> PostReplyEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> DeleteById(System.String @postIdentifier)
        {
            return DeleteByIdEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> DeleteByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> LockThreadById(System.String @threadIdentifier)
        {
            return LockThreadByIdEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> LockThreadByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> UnLockThreadById(System.String @threadIdentifier)
        {
            return UnLockThreadByIdEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> UnLockThreadByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetMyPublishedFeed(Microsoft.SharePoint.Client.Microfeed.MicrofeedRetrievalOptions @feedOptions, Microsoft.SharePoint.Client.Microfeed.MicrofeedPublishedFeedType @typeOfPubFeed, System.Boolean @ShowPublicView)
        {
            return GetMyPublishedFeedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetMyPublishedFeedEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetPublishedFeed(System.String @feedOwner, Microsoft.SharePoint.Client.Microfeed.MicrofeedRetrievalOptions @feedOptions, Microsoft.SharePoint.Client.Microfeed.MicrofeedPublishedFeedType @typeOfPubFeed)
        {
            return GetPublishedFeedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetPublishedFeedEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> GetThread(System.String @postIdentifier)
        {
            return GetThreadEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> GetThreadEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetMyConsolidatedFeed(Microsoft.SharePoint.Client.Microfeed.MicrofeedRetrievalOptions @feedOptions)
        {
            return GetMyConsolidatedFeedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetMyConsolidatedFeedEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetMyCategoricalFeed(Microsoft.SharePoint.Client.Microfeed.MicrofeedRetrievalOptions @feedOptions)
        {
            return GetMyCategoricalFeedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThreadCollection> GetMyCategoricalFeedEx { get; set;}

        public override void UnsubscribeFromEMail(System.String @postIdentifier)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> Like(System.String @postIdentifier)
        {
            return LikeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> LikeEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> UnLike(System.String @postIdentifier)
        {
            return UnLikeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedThread> UnLikeEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUnreadMentionsCount()
        {
            return GetUnreadMentionsCountEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUnreadMentionsCountEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> ClearUnreadMentionsCount()
        {
            return ClearUnreadMentionsCountEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> ClearUnreadMentionsCountEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> RepopulateLMT(System.DateTime @timeStamp, System.String @secureHash)
        {
            return RepopulateLMTEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> RepopulateLMTEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> AddUserToPostPeopleList(System.String @postIdentifier, System.String @UserLoginName)
        {
            return AddUserToPostPeopleListEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> AddUserToPostPeopleListEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> DeleteUserFromPostPeopleList(System.String @postIdentifier, System.String @UserLoginName)
        {
            return DeleteUserFromPostPeopleListEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode> DeleteUserFromPostPeopleListEx { get; set;}

    }
}

