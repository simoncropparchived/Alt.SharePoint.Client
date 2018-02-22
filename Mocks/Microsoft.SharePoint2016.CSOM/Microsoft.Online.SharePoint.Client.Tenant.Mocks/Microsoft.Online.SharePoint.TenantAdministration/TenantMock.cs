
// ReSharper disable IdentifierTypo
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

        public override Microsoft.SharePoint.Client.Site GetSiteByUrl(System.String @url)
        {
            return GetSiteByUrlEx;
        }
        public Microsoft.SharePoint.Client.Site GetSiteByUrlEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SiteProperties GetSitePropertiesByUrl(System.String @url, System.Boolean @includeDetail)
        {
            return GetSitePropertiesByUrlEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SiteProperties GetSitePropertiesByUrlEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSiteProperties(System.Int32 @startIndex, System.Boolean @includeDetail)
        {
            return GetSitePropertiesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesByFilter(System.String @filter, System.Int32 @startIndex, System.Boolean @includeDetail)
        {
            return GetSitePropertiesByFilterEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOSitePropertiesEnumerable GetSitePropertiesByFilterEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation CreateSite(Microsoft.Online.SharePoint.TenantAdministration.SiteCreationProperties @siteCreationProperties)
        {
            return CreateSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation CreateSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplateCollection GetSPOTenantWebTemplates(System.UInt32 @localeId, System.Int32 @compatibilityLevel)
        {
            return GetSPOTenantWebTemplatesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPOTenantWebTemplateCollection GetSPOTenantWebTemplatesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveSite(System.String @siteUrl)
        {
            return RemoveSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.DeletedSiteProperties GetDeletedSitePropertiesByUrl(System.String @siteUrl)
        {
            return GetDeletedSitePropertiesByUrlEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.DeletedSiteProperties GetDeletedSitePropertiesByUrlEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedSiteProperties(System.Int32 @startIndex)
        {
            return GetDeletedSitePropertiesEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SPODeletedSitePropertiesEnumerable GetDeletedSitePropertiesEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveDeletedSite(System.String @siteUrl)
        {
            return RemoveDeletedSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RemoveDeletedSiteEx { get; set;}

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RestoreDeletedSite(System.String @siteUrl)
        {
            return RestoreDeletedSiteEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation RestoreDeletedSiteEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> EncodeClaim(System.String @identifier)
        {
            return EncodeClaimEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> EncodeClaimEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> DecodeClaim(System.String @identifier)
        {
            return DecodeClaimEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> DecodeClaimEx { get; set;}

        public override System.Collections.Generic.IList<System.String> EncodeClaims(System.Collections.Generic.IList<System.String> @identifiers)
        {
            return EncodeClaimsEx;
        }
        public System.Collections.Generic.IList<System.String> EncodeClaimsEx { get; set;}

        public override System.Collections.Generic.IList<System.String> DecodeClaims(System.Collections.Generic.IList<System.String> @claims)
        {
            return DecodeClaimsEx;
        }
        public System.Collections.Generic.IList<System.String> DecodeClaimsEx { get; set;}

        public override Microsoft.SharePoint.Client.User SetSiteAdmin(System.String @url, System.String @loginName, System.Boolean @isSiteAdmin)
        {
            return SetSiteAdminEx;
        }
        public Microsoft.SharePoint.Client.User SetSiteAdminEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppErrorEntry> GetAppErrors(System.Guid @productId, System.DateTime @timeStart, System.DateTime @timeEnd)
        {
            return GetAppErrorsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppErrorEntry> GetAppErrorsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByProductId(System.Guid @productId)
        {
            return GetAppInfoByProductIdEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByProductIdEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByName(System.String @name)
        {
            return GetAppInfoByNameEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.AppInfo> GetAppInfoByNameEx { get; set;}

    }
}

