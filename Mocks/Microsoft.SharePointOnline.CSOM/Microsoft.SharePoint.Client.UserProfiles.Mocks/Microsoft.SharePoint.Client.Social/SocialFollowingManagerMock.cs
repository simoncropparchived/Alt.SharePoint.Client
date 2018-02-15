
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialFollowingManagerMock
    {


        public override System.String FollowedDocumentsUri => FollowedDocumentsUriEx;
        public System.String FollowedDocumentsUriEx { get; set; }

        public override System.String FollowedSitesUri => FollowedSitesUriEx;
        public System.String FollowedSitesUriEx { get; set; }

    }
}

