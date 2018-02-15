
namespace Microsoft.SharePoint.Client
{
    public class AppLicenseMock : AppLicense
    {


        public override System.String RawXMLLicenseToken => RawXMLLicenseTokenEx;
        public System.String RawXMLLicenseTokenEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

