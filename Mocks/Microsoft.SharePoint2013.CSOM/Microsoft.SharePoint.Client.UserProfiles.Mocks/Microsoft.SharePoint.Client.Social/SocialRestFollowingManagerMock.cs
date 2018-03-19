
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialRestFollowingManagerMock : SocialRestFollowingManager
    {


        public override System.String FollowedDocumentsUri => FollowedDocumentsUriEx;
        public System.String FollowedDocumentsUriEx { get; set; }

        public override System.String FollowedSitesUri => FollowedSitesUriEx;
        public System.String FollowedSitesUriEx { get; set; }

        public override System.String MyFollowedDocumentsUri => MyFollowedDocumentsUriEx;
        public System.String MyFollowedDocumentsUriEx { get; set; }

        public override System.String MyFollowedSitesUri => MyFollowedSitesUriEx;
        public System.String MyFollowedSitesUriEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialActor SocialActor => SocialActorEx;
        public Microsoft.SharePoint.Client.Social.SocialActor SocialActorEx { get; set; }

    }
}

