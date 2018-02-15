
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class Office365TenantMock
    {


        public override System.Boolean DisplayStartASiteOption => DisplayStartASiteOptionEx;
        public System.Boolean DisplayStartASiteOptionEx { get; set; }

        public override System.Boolean ExternalServicesEnabled => ExternalServicesEnabledEx;
        public System.Boolean ExternalServicesEnabledEx { get; set; }

        public override System.Boolean MySitesPublicEnabled => MySitesPublicEnabledEx;
        public System.Boolean MySitesPublicEnabledEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapability => SharingCapabilityEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapabilityEx { get; set; }

        public override System.String StartASiteFormUrl => StartASiteFormUrlEx;
        public System.String StartASiteFormUrlEx { get; set; }

    }
}

