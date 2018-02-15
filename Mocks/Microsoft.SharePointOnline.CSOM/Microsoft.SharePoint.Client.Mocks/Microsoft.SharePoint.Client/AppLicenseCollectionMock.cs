
namespace Microsoft.SharePoint.Client
{
    public class AppLicenseCollectionMock : AppLicenseCollection
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

