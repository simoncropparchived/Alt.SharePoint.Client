
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class ComplianceTagMock : ComplianceTag
    {


        public override System.Boolean AcceptMessagesOnlyFromSendersOrMembers => AcceptMessagesOnlyFromSendersOrMembersEx;
        public System.Boolean AcceptMessagesOnlyFromSendersOrMembersEx { get; set; }

        public override System.String AccessType => AccessTypeEx;
        public System.String AccessTypeEx { get; set; }

        public override System.String AllowAccessFromUnmanagedDevice => AllowAccessFromUnmanagedDeviceEx;
        public System.String AllowAccessFromUnmanagedDeviceEx { get; set; }

        public override System.Boolean AutoDelete => AutoDeleteEx;
        public System.Boolean AutoDeleteEx { get; set; }

        public override System.Boolean BlockDelete => BlockDeleteEx;
        public System.Boolean BlockDeleteEx { get; set; }

        public override System.Boolean BlockEdit => BlockEditEx;
        public System.Boolean BlockEditEx { get; set; }

        public override System.Boolean ContainsSiteLabel => ContainsSiteLabelEx;
        public System.Boolean ContainsSiteLabelEx { get; set; }

        public override System.Boolean HasRetentionAction => HasRetentionActionEx;
        public System.Boolean HasRetentionActionEx { get; set; }

        public override System.Boolean IsEventTag => IsEventTagEx;
        public System.Boolean IsEventTagEx { get; set; }

        public override System.String Notes => NotesEx;
        public System.String NotesEx { get; set; }

        public override System.Boolean RequireSenderAuthenticationEnabled => RequireSenderAuthenticationEnabledEx;
        public System.Boolean RequireSenderAuthenticationEnabledEx { get; set; }

        public override System.String ReviewerEmail => ReviewerEmailEx;
        public System.String ReviewerEmailEx { get; set; }

        public override System.String SharingCapabilities => SharingCapabilitiesEx;
        public System.String SharingCapabilitiesEx { get; set; }

        public override System.Int32 TagDuration => TagDurationEx;
        public System.Int32 TagDurationEx { get; set; }

        public override System.Guid TagId => TagIdEx;
        public System.Guid TagIdEx { get; set; }

        public override System.String TagName => TagNameEx;
        public System.String TagNameEx { get; set; }

        public override System.String TagRetentionBasedOn => TagRetentionBasedOnEx;
        public System.String TagRetentionBasedOnEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

