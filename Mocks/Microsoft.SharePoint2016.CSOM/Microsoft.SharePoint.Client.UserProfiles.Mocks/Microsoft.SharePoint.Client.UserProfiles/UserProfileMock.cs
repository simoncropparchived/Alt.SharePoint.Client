
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class UserProfileMock : UserProfile
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override Microsoft.SharePoint.Client.UserProfiles.FollowedContent FollowedContent => FollowedContentEx;
        public Microsoft.SharePoint.Client.UserProfiles.FollowedContent FollowedContentEx { get; set; }

        public override System.String FollowPersonalSiteUrl => FollowPersonalSiteUrlEx;
        public System.String FollowPersonalSiteUrlEx { get; set; }

        public override System.Boolean IsPeopleListPublic => IsPeopleListPublicEx;
        public System.Boolean IsPeopleListPublicEx { get; set; }

        public override System.Boolean IsPrivacySettingOn => IsPrivacySettingOnEx;
        public System.Boolean IsPrivacySettingOnEx { get; set; }

        public override System.Boolean IsSelf => IsSelfEx;
        public System.Boolean IsSelfEx { get; set; }

        public override System.String JobTitle => JobTitleEx;
        public System.String JobTitleEx { get; set; }

        public override System.Int32 MySiteFirstRunExperience => MySiteFirstRunExperienceEx;
        public System.Int32 MySiteFirstRunExperienceEx { get; set; }

        public override System.String MySiteHostUrl => MySiteHostUrlEx;
        public System.String MySiteHostUrlEx { get; set; }

        public override System.Int32 O15FirstRunExperience => O15FirstRunExperienceEx;
        public System.Int32 O15FirstRunExperienceEx { get; set; }

        public override Microsoft.SharePoint.Client.Site PersonalSite => PersonalSiteEx;
        public Microsoft.SharePoint.Client.Site PersonalSiteEx { get; set; }

        public override Microsoft.SharePoint.Client.UserProfiles.PersonalSiteCapabilities PersonalSiteCapabilities => PersonalSiteCapabilitiesEx;
        public Microsoft.SharePoint.Client.UserProfiles.PersonalSiteCapabilities PersonalSiteCapabilitiesEx { get; set; }

        public override System.String PersonalSiteFirstCreationError => PersonalSiteFirstCreationErrorEx;
        public System.String PersonalSiteFirstCreationErrorEx { get; set; }

        public override System.DateTime PersonalSiteFirstCreationTime => PersonalSiteFirstCreationTimeEx;
        public System.DateTime PersonalSiteFirstCreationTimeEx { get; set; }

        public override Microsoft.SharePoint.Client.UserProfiles.PersonalSiteInstantiationState PersonalSiteInstantiationState => PersonalSiteInstantiationStateEx;
        public Microsoft.SharePoint.Client.UserProfiles.PersonalSiteInstantiationState PersonalSiteInstantiationStateEx { get; set; }

        public override System.DateTime PersonalSiteLastCreationTime => PersonalSiteLastCreationTimeEx;
        public System.DateTime PersonalSiteLastCreationTimeEx { get; set; }

        public override System.Int32 PersonalSiteNumberOfRetries => PersonalSiteNumberOfRetriesEx;
        public System.Int32 PersonalSiteNumberOfRetriesEx { get; set; }

        public override System.Boolean PictureImportEnabled => PictureImportEnabledEx;
        public System.Boolean PictureImportEnabledEx { get; set; }

        public override System.String PictureUrl => PictureUrlEx;
        public System.String PictureUrlEx { get; set; }

        public override System.String PublicUrl => PublicUrlEx;
        public System.String PublicUrlEx { get; set; }

        public override System.String SipAddress => SipAddressEx;
        public System.String SipAddressEx { get; set; }

        public override System.String UrlToCreatePersonalSite => UrlToCreatePersonalSiteEx;
        public System.String UrlToCreatePersonalSiteEx { get; set; }

    }
}

