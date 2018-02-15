
namespace Microsoft.SharePoint.Client.Sharing
{
    public class UserSharingResultMock : UserSharingResult
    {


        public override System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.Sharing.Role> AllowedRoles => AllowedRolesEx;
        public System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.Sharing.Role> AllowedRolesEx { get; set; }

        public override Microsoft.SharePoint.Client.Sharing.Role CurrentRole => CurrentRoleEx;
        public Microsoft.SharePoint.Client.Sharing.Role CurrentRoleEx { get; set; }

        public override System.Boolean IsUserKnown => IsUserKnownEx;
        public System.Boolean IsUserKnownEx { get; set; }

        public override System.String Message => MessageEx;
        public System.String MessageEx { get; set; }

        public override System.Boolean Status => StatusEx;
        public System.Boolean StatusEx { get; set; }

        public override System.String User => UserEx;
        public System.String UserEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

