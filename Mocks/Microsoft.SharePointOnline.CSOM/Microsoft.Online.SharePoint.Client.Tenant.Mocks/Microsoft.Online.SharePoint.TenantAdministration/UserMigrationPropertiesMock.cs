
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class UserMigrationPropertiesMock : UserMigrationProperties
    {


        public override Microsoft.Online.SharePoint.TenantAdministration.OdbMigrationStatus OdbMigrationStatus => OdbMigrationStatusEx;
        public Microsoft.Online.SharePoint.TenantAdministration.OdbMigrationStatus OdbMigrationStatusEx { get; set; }

        public override System.String SourcePuid => SourcePuidEx;
        public System.String SourcePuidEx { get; set; }

        public override System.String SourceUpn => SourceUpnEx;
        public System.String SourceUpnEx { get; set; }

        public override System.String TargetPuid => TargetPuidEx;
        public System.String TargetPuidEx { get; set; }

        public override System.String TargetUpn => TargetUpnEx;
        public System.String TargetUpnEx { get; set; }

    }
}

