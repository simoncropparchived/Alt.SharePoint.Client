
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantManagement
{
    public class Office365TenantMock : Office365Tenant
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

        public override Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsers(System.Int32 @position, System.Int32 @pageSize, System.String @filter, Microsoft.Online.SharePoint.TenantManagement.SortOrder @sortOrder)
        {
            return GetExternalUsersEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.GetExternalUsersResults GetExternalUsersEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantManagement.RemoveExternalUsersResults RemoveExternalUsers(System.String[] @uniqueIds)
        {
            return RemoveExternalUsersEx;
        }
        public Microsoft.Online.SharePoint.TenantManagement.RemoveExternalUsersResults RemoveExternalUsersEx { get; set;}

    }
}

