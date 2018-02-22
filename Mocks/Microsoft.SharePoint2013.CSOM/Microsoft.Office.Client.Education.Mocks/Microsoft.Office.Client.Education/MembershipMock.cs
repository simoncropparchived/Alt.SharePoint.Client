
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.Client.Education
{
    public class MembershipMock : Membership
    {


        public override System.String CommunityId => CommunityIdEx;
        public System.String CommunityIdEx { get; set; }

        public override Microsoft.Office.Client.Education.CommunityMembershipRole Role => RoleEx;
        public Microsoft.Office.Client.Education.CommunityMembershipRole RoleEx { get; set; }

        public override System.String UserId => UserIdEx;
        public System.String UserIdEx { get; set; }

        public override System.String UserName => UserNameEx;
        public System.String UserNameEx { get; set; }

    }
}

