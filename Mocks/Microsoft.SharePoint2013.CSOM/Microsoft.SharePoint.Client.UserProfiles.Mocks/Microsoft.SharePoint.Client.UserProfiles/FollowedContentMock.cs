
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class FollowedContentMock
    {


        public override System.String FollowedDocumentsUrl => FollowedDocumentsUrlEx;
        public System.String FollowedDocumentsUrlEx { get; set; }

        public override System.String FollowedSitesUrl => FollowedSitesUrlEx;
        public System.String FollowedSitesUrlEx { get; set; }

    }
}

