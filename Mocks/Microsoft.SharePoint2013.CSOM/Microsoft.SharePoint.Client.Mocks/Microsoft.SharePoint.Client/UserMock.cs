
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class UserMock : User
    {


        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override Microsoft.SharePoint.Client.GroupCollection Groups => GroupsEx;
        public Microsoft.SharePoint.Client.GroupCollection GroupsEx { get; set; }

        public override System.Boolean IsSiteAdmin => IsSiteAdminEx;
        public System.Boolean IsSiteAdminEx { get; set; }

        public override Microsoft.SharePoint.Client.UserIdInfo UserId => UserIdEx;
        public Microsoft.SharePoint.Client.UserIdInfo UserIdEx { get; set; }

        public override void Update()
        {
        }

    }
}

