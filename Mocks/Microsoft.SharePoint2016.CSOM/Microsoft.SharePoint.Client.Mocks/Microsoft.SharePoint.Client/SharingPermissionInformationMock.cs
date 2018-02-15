
namespace Microsoft.SharePoint.Client
{
    public class SharingPermissionInformationMock
    {


        public override System.Boolean IsDefaultPermission => IsDefaultPermissionEx;
        public System.Boolean IsDefaultPermissionEx { get; set; }

        public override System.String PermissionDescription => PermissionDescriptionEx;
        public System.String PermissionDescriptionEx { get; set; }

        public override System.String PermissionId => PermissionIdEx;
        public System.String PermissionIdEx { get; set; }

        public override Microsoft.SharePoint.Client.SharingPermissionKind PermissionKind => PermissionKindEx;
        public Microsoft.SharePoint.Client.SharingPermissionKind PermissionKindEx { get; set; }

        public override System.String PermissionName => PermissionNameEx;
        public System.String PermissionNameEx { get; set; }

    }
}

