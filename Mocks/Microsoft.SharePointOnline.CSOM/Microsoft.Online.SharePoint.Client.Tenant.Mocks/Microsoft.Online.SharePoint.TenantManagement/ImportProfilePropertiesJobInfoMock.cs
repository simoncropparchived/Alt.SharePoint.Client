
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class ImportProfilePropertiesJobInfoMock : ImportProfilePropertiesJobInfo
    {


        public override Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobError Error => ErrorEx;
        public Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobError ErrorEx { get; set; }

        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override System.Guid JobId => JobIdEx;
        public System.Guid JobIdEx { get; set; }

        public override System.String LogFolderUri => LogFolderUriEx;
        public System.String LogFolderUriEx { get; set; }

        public override System.String SourceUri => SourceUriEx;
        public System.String SourceUriEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobState State => StateEx;
        public Microsoft.Online.SharePoint.TenantManagement.ImportProfilePropertiesJobState StateEx { get; set; }

    }
}

