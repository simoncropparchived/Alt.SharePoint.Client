
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialFeedManagerMock : SocialFeedManager
    {


        public override Microsoft.SharePoint.Client.Social.SocialActor Owner => OwnerEx;
        public Microsoft.SharePoint.Client.Social.SocialActor OwnerEx { get; set; }

        public override System.String PersonalSitePortalUri => PersonalSitePortalUriEx;
        public System.String PersonalSitePortalUriEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> CreatePost(System.String @targetId, Microsoft.SharePoint.Client.Social.SocialPostCreationData @creationData)
        {
            return CreatePostEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> CreatePostEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialAttachment> GetPreview(System.String @itemUrl)
        {
            return GetPreviewEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialAttachment> GetPreviewEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> LikePost(System.String @postId)
        {
            return LikePostEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> LikePostEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> UnlikePost(System.String @postId)
        {
            return UnlikePostEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> UnlikePostEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> DeletePost(System.String @postId)
        {
            return DeletePostEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> DeletePostEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> LockThread(System.String @threadId)
        {
            return LockThreadEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> LockThreadEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> UnlockThread(System.String @threadId)
        {
            return UnlockThreadEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> UnlockThreadEx { get; set;}

        public override void SuppressThreadNotifications(System.String @threadId)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFeed> GetFeed(Microsoft.SharePoint.Client.Social.SocialFeedType @type, Microsoft.SharePoint.Client.Social.SocialFeedOptions @options)
        {
            return GetFeedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFeed> GetFeedEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFeed> GetFeedFor(System.String @actorId, Microsoft.SharePoint.Client.Social.SocialFeedOptions @options)
        {
            return GetFeedForEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFeed> GetFeedForEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFeed> GetMentions(System.Boolean @clearUnreadMentions, Microsoft.SharePoint.Client.Social.SocialFeedOptions @options)
        {
            return GetMentionsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFeed> GetMentionsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUnreadMentionCount()
        {
            return GetUnreadMentionCountEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetUnreadMentionCountEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> GetFullThread(System.String @threadId)
        {
            return GetFullThreadEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialThread> GetFullThreadEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetAllLikers(System.String @postId)
        {
            return GetAllLikersEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetAllLikersEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialAttachment> CreateImageAttachment(System.String @name, System.String @description, System.IO.Stream @imageData)
        {
            return CreateImageAttachmentEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialAttachment> CreateImageAttachmentEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetPreviewImage(System.String @url, System.String @key, System.String @iv)
        {
            return GetPreviewImageEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetPreviewImageEx { get; set;}

    }
}

