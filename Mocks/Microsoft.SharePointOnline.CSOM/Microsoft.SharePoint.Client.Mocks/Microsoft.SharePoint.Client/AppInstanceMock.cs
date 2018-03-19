
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AppInstanceMock : AppInstance
    {


        public override System.String AppPrincipalId => AppPrincipalIdEx;
        public System.String AppPrincipalIdEx { get; set; }

        public override System.String AppWebFullUrl => AppWebFullUrlEx;
        public System.String AppWebFullUrlEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String ImageFallbackUrl => ImageFallbackUrlEx;
        public System.String ImageFallbackUrlEx { get; set; }

        public override System.String ImageUrl => ImageUrlEx;
        public System.String ImageUrlEx { get; set; }

        public override System.Boolean InError => InErrorEx;
        public System.Boolean InErrorEx { get; set; }

        public override System.String StartPage => StartPageEx;
        public System.String StartPageEx { get; set; }

        public override System.Byte[] PackageFingerprint => PackageFingerprintEx;
        public System.Byte[] PackageFingerprintEx { get; set; }

        public override System.Guid ProductId => ProductIdEx;
        public System.Guid ProductIdEx { get; set; }

        public override System.String RemoteAppUrl => RemoteAppUrlEx;
        public System.String RemoteAppUrlEx { get; set; }

        public override System.String SettingsPageUrl => SettingsPageUrlEx;
        public System.String SettingsPageUrlEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override Microsoft.SharePoint.Client.AppInstanceStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.AppInstanceStatus StatusEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.AppInstanceErrorDetails> GetErrorDetails()
        {
            return GetErrorDetailsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.AppInstanceErrorDetails> GetErrorDetailsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Uninstall()
        {
            return UninstallEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> UninstallEx { get; set;}

        public override void Upgrade(System.IO.Stream @appPackageStream)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> CancelAllJobs()
        {
            return CancelAllJobsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> CancelAllJobsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Install()
        {
            return InstallEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> InstallEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Recycle()
        {
            return RecycleEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> RecycleEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Restore()
        {
            return RestoreEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> RestoreEx { get; set;}

        public override Microsoft.SharePoint.Client.App GetPreviousAppVersion()
        {
            return GetPreviousAppVersionEx;
        }
        public Microsoft.SharePoint.Client.App GetPreviousAppVersionEx { get; set;}

        public override void RetryAllJobs()
        {
        }

    }
}

