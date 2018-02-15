
namespace Microsoft.SharePoint.Client
{
    public class TenantAppInformationMock
    {


        public override System.String AppPrincipalId => AppPrincipalIdEx;
        public System.String AppPrincipalIdEx { get; set; }

        public override System.String AppWebFullUrl => AppWebFullUrlEx;
        public System.String AppWebFullUrlEx { get; set; }

        public override System.DateTime CreationTime => CreationTimeEx;
        public System.DateTime CreationTimeEx { get; set; }

        public override System.String IconAbsoluteUrl => IconAbsoluteUrlEx;
        public System.String IconAbsoluteUrlEx { get; set; }

        public override System.String IconFallbackAbsoluteUrl => IconFallbackAbsoluteUrlEx;
        public System.String IconFallbackAbsoluteUrlEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String LaunchUrl => LaunchUrlEx;
        public System.String LaunchUrlEx { get; set; }

        public override System.Byte[] PackageFingerprint => PackageFingerprintEx;
        public System.Byte[] PackageFingerprintEx { get; set; }

        public override System.Guid ProductId => ProductIdEx;
        public System.Guid ProductIdEx { get; set; }

        public override System.String RemoteAppUrl => RemoteAppUrlEx;
        public System.String RemoteAppUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.AppInstanceStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.AppInstanceStatus StatusEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

