
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialFollowingManagerMock : SocialFollowingManager
    {


        public override System.String FollowedDocumentsUri => FollowedDocumentsUriEx;
        public System.String FollowedDocumentsUriEx { get; set; }

        public override System.String FollowedSitesUri => FollowedSitesUriEx;
        public System.String FollowedSitesUriEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFollowResult> Follow(Microsoft.SharePoint.Client.Social.SocialActorInfo @actor)
        {
            return FollowEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialFollowResult> FollowEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> StopFollowing(Microsoft.SharePoint.Client.Social.SocialActorInfo @actor)
        {
            return StopFollowingEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> StopFollowingEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsFollowed(Microsoft.SharePoint.Client.Social.SocialActorInfo @actor)
        {
            return IsFollowedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsFollowedEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetFollowed(Microsoft.SharePoint.Client.Social.SocialActorTypes @types)
        {
            return GetFollowedEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetFollowedEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> GetFollowedCount(Microsoft.SharePoint.Client.Social.SocialActorTypes @types)
        {
            return GetFollowedCountEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> GetFollowedCountEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetFollowers()
        {
            return GetFollowersEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetFollowersEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetSuggestions()
        {
            return GetSuggestionsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Social.SocialActor[]> GetSuggestionsEx { get; set;}

    }
}

