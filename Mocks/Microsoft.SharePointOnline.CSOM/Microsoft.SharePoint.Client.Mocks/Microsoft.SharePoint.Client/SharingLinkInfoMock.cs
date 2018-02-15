
namespace Microsoft.SharePoint.Client
{
    public class SharingLinkInfoMock : SharingLinkInfo
    {


        public override System.Boolean AllowsAnonymousAccess => AllowsAnonymousAccessEx;
        public System.Boolean AllowsAnonymousAccessEx { get; set; }

        public override System.String Created => CreatedEx;
        public System.String CreatedEx { get; set; }

        public override System.String Expiration => ExpirationEx;
        public System.String ExpirationEx { get; set; }

        public override System.Boolean HasExternalGuestInvitees => HasExternalGuestInviteesEx;
        public System.Boolean HasExternalGuestInviteesEx { get; set; }

        public override System.Boolean IsActive => IsActiveEx;
        public System.Boolean IsActiveEx { get; set; }

        public override System.Boolean IsEditLink => IsEditLinkEx;
        public System.Boolean IsEditLinkEx { get; set; }

        public override System.Boolean IsFormsLink => IsFormsLinkEx;
        public System.Boolean IsFormsLinkEx { get; set; }

        public override System.Boolean IsUnhealthy => IsUnhealthyEx;
        public System.Boolean IsUnhealthyEx { get; set; }

        public override System.String LastModified => LastModifiedEx;
        public System.String LastModifiedEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingLinkKind LinkKind => LinkKindEx;
        public Microsoft.SharePoint.Client.SharingLinkKind LinkKindEx { get; set; }

        public override System.Boolean RequiresPassword => RequiresPasswordEx;
        public System.Boolean RequiresPasswordEx { get; set; }

        public override System.Boolean RestrictedShareMembership => RestrictedShareMembershipEx;
        public System.Boolean RestrictedShareMembershipEx { get; set; }

        public override System.Guid ShareId => ShareIdEx;
        public System.Guid ShareIdEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

