
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class UserProfileMock
    {


        public override Microsoft.SharePoint.Client.UserProfiles.FollowedContent FollowedContent => FollowedContentEx;
        public Microsoft.SharePoint.Client.UserProfiles.FollowedContent FollowedContentEx { get; set; }

        public override Microsoft.SharePoint.Client.Site PersonalSite => PersonalSiteEx;
        public Microsoft.SharePoint.Client.Site PersonalSiteEx { get; set; }

        public override Microsoft.SharePoint.Client.UserProfiles.PersonalSiteCapabilities PersonalSiteCapabilities => PersonalSiteCapabilitiesEx;
        public Microsoft.SharePoint.Client.UserProfiles.PersonalSiteCapabilities PersonalSiteCapabilitiesEx { get; set; }

        public override Microsoft.SharePoint.Client.UserProfiles.PersonalSiteInstantiationState PersonalSiteInstantiationState => PersonalSiteInstantiationStateEx;
        public Microsoft.SharePoint.Client.UserProfiles.PersonalSiteInstantiationState PersonalSiteInstantiationStateEx { get; set; }

        public override System.Boolean PictureImportEnabled => PictureImportEnabledEx;
        public System.Boolean PictureImportEnabledEx { get; set; }

        public override System.String UrlToCreatePersonalSite => UrlToCreatePersonalSiteEx;
        public System.String UrlToCreatePersonalSiteEx { get; set; }

    }
}

