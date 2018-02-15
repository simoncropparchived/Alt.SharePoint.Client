
namespace Microsoft.SharePoint.Client
{
    public class IngestionTaskKeyMock
    {


        public override System.String IngestionTableAccountKey => IngestionTableAccountKeyEx;
        public System.String IngestionTableAccountKeyEx { get; set; }

        public override System.String IngestionTableAccountName => IngestionTableAccountNameEx;
        public System.String IngestionTableAccountNameEx { get; set; }

        public override System.String JobId => JobIdEx;
        public System.String JobIdEx { get; set; }

        public override System.String TaskId => TaskIdEx;
        public System.String TaskIdEx { get; set; }

        public override System.String TenantName => TenantNameEx;
        public System.String TenantNameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

