
namespace Microsoft.SharePoint.Client.Publishing
{
    public class DesignPackageInfoMock : DesignPackageInfo
    {


        public override System.Int32 MajorVersion => MajorVersionEx;
        public System.Int32 MajorVersionEx { get; set; }

        public override System.Int32 MinorVersion => MinorVersionEx;
        public System.Int32 MinorVersionEx { get; set; }

        public override System.Guid PackageGuid => PackageGuidEx;
        public System.Guid PackageGuidEx { get; set; }

        public override System.String PackageName => PackageNameEx;
        public System.String PackageNameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

