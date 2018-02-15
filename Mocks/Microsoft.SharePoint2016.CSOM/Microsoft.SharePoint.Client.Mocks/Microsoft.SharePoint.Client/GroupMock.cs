
namespace Microsoft.SharePoint.Client
{
    public class GroupMock
    {


        public override System.Boolean AllowMembersEditMembership => AllowMembersEditMembershipEx;
        public System.Boolean AllowMembersEditMembershipEx { get; set; }

        public override System.Boolean AllowRequestToJoinLeave => AllowRequestToJoinLeaveEx;
        public System.Boolean AllowRequestToJoinLeaveEx { get; set; }

        public override System.Boolean AutoAcceptRequestToJoinLeave => AutoAcceptRequestToJoinLeaveEx;
        public System.Boolean AutoAcceptRequestToJoinLeaveEx { get; set; }

        public override System.Boolean CanCurrentUserEditMembership => CanCurrentUserEditMembershipEx;
        public System.Boolean CanCurrentUserEditMembershipEx { get; set; }

        public override System.Boolean CanCurrentUserManageGroup => CanCurrentUserManageGroupEx;
        public System.Boolean CanCurrentUserManageGroupEx { get; set; }

        public override System.Boolean CanCurrentUserViewMembership => CanCurrentUserViewMembershipEx;
        public System.Boolean CanCurrentUserViewMembershipEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean OnlyAllowMembersViewMembership => OnlyAllowMembersViewMembershipEx;
        public System.Boolean OnlyAllowMembersViewMembershipEx { get; set; }

        public override Microsoft.SharePoint.Client.Principal Owner => OwnerEx;
        public Microsoft.SharePoint.Client.Principal OwnerEx { get; set; }

        public override System.String OwnerTitle => OwnerTitleEx;
        public System.String OwnerTitleEx { get; set; }

        public override System.String RequestToJoinLeaveEmailSetting => RequestToJoinLeaveEmailSettingEx;
        public System.String RequestToJoinLeaveEmailSettingEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCollection Users => UsersEx;
        public Microsoft.SharePoint.Client.UserCollection UsersEx { get; set; }

    }
}

