
namespace Microsoft.SharePoint.Client.Sharing
{
    public class UserRoleAssignmentMock : UserRoleAssignment
    {


        public override Microsoft.SharePoint.Client.Sharing.Role Role => RoleEx;
        public Microsoft.SharePoint.Client.Sharing.Role RoleEx { get; set; }

        public override System.String UserId => UserIdEx;
        public System.String UserIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

