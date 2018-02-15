
namespace Microsoft.SharePoint.Client
{
    public class CopyJobProgressMock
    {


        public override Microsoft.SharePoint.Client.MigrationJobState JobState => JobStateEx;
        public Microsoft.SharePoint.Client.MigrationJobState JobStateEx { get; set; }

        public override System.Collections.Generic.IList`1<System.String> Logs => LogsEx;
        public System.Collections.Generic.IList`1<System.String> LogsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

