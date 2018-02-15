
namespace Microsoft.SharePoint.Client
{
    public class UpgradeInfoMock : UpgradeInfo
    {


        public override System.String ErrorFile => ErrorFileEx;
        public System.String ErrorFileEx { get; set; }

        public override System.Int32 Errors => ErrorsEx;
        public System.Int32 ErrorsEx { get; set; }

        public override System.DateTime LastUpdated => LastUpdatedEx;
        public System.DateTime LastUpdatedEx { get; set; }

        public override System.String LogFile => LogFileEx;
        public System.String LogFileEx { get; set; }

        public override System.DateTime RequestDate => RequestDateEx;
        public System.DateTime RequestDateEx { get; set; }

        public override System.Int32 RetryCount => RetryCountEx;
        public System.Int32 RetryCountEx { get; set; }

        public override System.DateTime StartTime => StartTimeEx;
        public System.DateTime StartTimeEx { get; set; }

        public override Microsoft.SharePoint.Client.UpgradeStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.UpgradeStatus StatusEx { get; set; }

        public override Microsoft.SharePoint.Client.UpgradeType UpgradeType => UpgradeTypeEx;
        public Microsoft.SharePoint.Client.UpgradeType UpgradeTypeEx { get; set; }

        public override System.Int32 Warnings => WarningsEx;
        public System.Int32 WarningsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

