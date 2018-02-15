
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialFeedManagerMock
    {


        public override Microsoft.SharePoint.Client.Social.SocialActor Owner => OwnerEx;
        public Microsoft.SharePoint.Client.Social.SocialActor OwnerEx { get; set; }

        public override System.String PersonalSitePortalUri => PersonalSitePortalUriEx;
        public System.String PersonalSitePortalUriEx { get; set; }

    }
}

