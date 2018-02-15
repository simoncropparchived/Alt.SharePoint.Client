
namespace Microsoft.SharePoint.Client
{
    public class UserMock
    {


        public override Microsoft.SharePoint.Client.UserIdInfo AadObjectId => AadObjectIdEx;
        public Microsoft.SharePoint.Client.UserIdInfo AadObjectIdEx { get; set; }

        public override Microsoft.SharePoint.Client.AlertCollection Alerts => AlertsEx;
        public Microsoft.SharePoint.Client.AlertCollection AlertsEx { get; set; }

        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override Microsoft.SharePoint.Client.GroupCollection Groups => GroupsEx;
        public Microsoft.SharePoint.Client.GroupCollection GroupsEx { get; set; }

        public override System.Boolean IsEmailAuthenticationGuestUser => IsEmailAuthenticationGuestUserEx;
        public System.Boolean IsEmailAuthenticationGuestUserEx { get; set; }

        public override System.Boolean IsShareByEmailGuestUser => IsShareByEmailGuestUserEx;
        public System.Boolean IsShareByEmailGuestUserEx { get; set; }

        public override System.Boolean IsSiteAdmin => IsSiteAdminEx;
        public System.Boolean IsSiteAdminEx { get; set; }

        public override Microsoft.SharePoint.Client.UserIdInfo UserId => UserIdEx;
        public Microsoft.SharePoint.Client.UserIdInfo UserIdEx { get; set; }

    }
}

