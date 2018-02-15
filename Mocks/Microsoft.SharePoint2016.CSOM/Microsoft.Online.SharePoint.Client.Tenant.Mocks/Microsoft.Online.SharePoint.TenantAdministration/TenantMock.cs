
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantMock : Tenant
    {


        public override System.String CompatibilityRange => CompatibilityRangeEx;
        public System.String CompatibilityRangeEx { get; set; }

        public override System.Boolean DisplayStartASiteOption => DisplayStartASiteOptionEx;
        public System.Boolean DisplayStartASiteOptionEx { get; set; }

        public override System.Boolean ExternalServicesEnabled => ExternalServicesEnabledEx;
        public System.Boolean ExternalServicesEnabledEx { get; set; }

        public override System.String NoAccessRedirectUrl => NoAccessRedirectUrlEx;
        public System.String NoAccessRedirectUrlEx { get; set; }

        public override System.Double ResourceQuota => ResourceQuotaEx;
        public System.Double ResourceQuotaEx { get; set; }

        public override System.Double ResourceQuotaAllocated => ResourceQuotaAllocatedEx;
        public System.Double ResourceQuotaAllocatedEx { get; set; }

        public override System.String RootSiteUrl => RootSiteUrlEx;
        public System.String RootSiteUrlEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapability => SharingCapabilityEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapabilityEx { get; set; }

        public override System.String StartASiteFormUrl => StartASiteFormUrlEx;
        public System.String StartASiteFormUrlEx { get; set; }

        public override System.Int64 StorageQuota => StorageQuotaEx;
        public System.Int64 StorageQuotaEx { get; set; }

        public override System.Int64 StorageQuotaAllocated => StorageQuotaAllocatedEx;
        public System.Int64 StorageQuotaAllocatedEx { get; set; }

    }
}

