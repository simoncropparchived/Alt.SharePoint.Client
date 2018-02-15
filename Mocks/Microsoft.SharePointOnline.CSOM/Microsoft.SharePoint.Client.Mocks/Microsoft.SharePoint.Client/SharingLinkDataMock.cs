
namespace Microsoft.SharePoint.Client
{
    public class SharingLinkDataMock
    {


        public override System.String Expiration => ExpirationEx;
        public System.String ExpirationEx { get; set; }

        public override System.Boolean HasExternalGuestInvitees => HasExternalGuestInviteesEx;
        public System.Boolean HasExternalGuestInviteesEx { get; set; }

        public override System.Boolean IsAnonymous => IsAnonymousEx;
        public System.Boolean IsAnonymousEx { get; set; }

        public override System.Boolean IsFormsLink => IsFormsLinkEx;
        public System.Boolean IsFormsLinkEx { get; set; }

        public override System.Boolean IsOriginatedFromSharingFlow => IsOriginatedFromSharingFlowEx;
        public System.Boolean IsOriginatedFromSharingFlowEx { get; set; }

        public override System.Boolean IsSharingLink => IsSharingLinkEx;
        public System.Boolean IsSharingLinkEx { get; set; }

        public override System.Boolean IsWritable => IsWritableEx;
        public System.Boolean IsWritableEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingLinkKind LinkKind => LinkKindEx;
        public Microsoft.SharePoint.Client.SharingLinkKind LinkKindEx { get; set; }

        public override Microsoft.SharePoint.Client.Sharing.SharedObjectType ObjectType => ObjectTypeEx;
        public Microsoft.SharePoint.Client.Sharing.SharedObjectType ObjectTypeEx { get; set; }

        public override System.Guid ObjectUniqueId => ObjectUniqueIdEx;
        public System.Guid ObjectUniqueIdEx { get; set; }

        public override System.Boolean RequiresPassword => RequiresPasswordEx;
        public System.Boolean RequiresPasswordEx { get; set; }

        public override System.Boolean RestrictedShareMembership => RestrictedShareMembershipEx;
        public System.Boolean RestrictedShareMembershipEx { get; set; }

        public override System.Guid ShareId => ShareIdEx;
        public System.Guid ShareIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

