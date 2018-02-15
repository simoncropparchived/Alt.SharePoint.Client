
namespace Microsoft.SharePoint.Client
{
    public class SPMigrationJobStatusMock : SPMigrationJobStatus
    {


        public override System.Guid JobId => JobIdEx;
        public System.Guid JobIdEx { get; set; }

        public override Microsoft.SharePoint.Client.MigrationJobState JobState => JobStateEx;
        public Microsoft.SharePoint.Client.MigrationJobState JobStateEx { get; set; }

    }
}

