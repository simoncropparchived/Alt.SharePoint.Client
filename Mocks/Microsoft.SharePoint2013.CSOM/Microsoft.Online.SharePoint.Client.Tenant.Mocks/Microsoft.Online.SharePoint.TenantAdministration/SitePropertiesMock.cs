
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SitePropertiesMock : SiteProperties
    {


        public override System.Boolean AllowSelfServiceUpgrade => AllowSelfServiceUpgradeEx;
        public System.Boolean AllowSelfServiceUpgradeEx { get; set; }

        public override System.Double AverageResourceUsage => AverageResourceUsageEx;
        public System.Double AverageResourceUsageEx { get; set; }

        public override System.Int32 CompatibilityLevel => CompatibilityLevelEx;
        public System.Int32 CompatibilityLevelEx { get; set; }

        public override System.Double CurrentResourceUsage => CurrentResourceUsageEx;
        public System.Double CurrentResourceUsageEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.DenyAddAndCustomizePagesStatus DenyAddAndCustomizePages => DenyAddAndCustomizePagesEx;
        public Microsoft.Online.SharePoint.TenantAdministration.DenyAddAndCustomizePagesStatus DenyAddAndCustomizePagesEx { get; set; }

        public override System.DateTime LastContentModifiedDate => LastContentModifiedDateEx;
        public System.DateTime LastContentModifiedDateEx { get; set; }

        public override System.UInt32 Lcid => LcidEx;
        public System.UInt32 LcidEx { get; set; }

        public override System.String LockIssue => LockIssueEx;
        public System.String LockIssueEx { get; set; }

        public override System.String LockState => LockStateEx;
        public System.String LockStateEx { get; set; }

        public override System.String Owner => OwnerEx;
        public System.String OwnerEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapability => SharingCapabilityEx;
        public Microsoft.Online.SharePoint.TenantManagement.SharingCapabilities SharingCapabilityEx { get; set; }

        public override System.String Status => StatusEx;
        public System.String StatusEx { get; set; }

        public override System.Int64 StorageMaximumLevel => StorageMaximumLevelEx;
        public System.Int64 StorageMaximumLevelEx { get; set; }

        public override System.Int64 StorageUsage => StorageUsageEx;
        public System.Int64 StorageUsageEx { get; set; }

        public override System.Int64 StorageWarningLevel => StorageWarningLevelEx;
        public System.Int64 StorageWarningLevelEx { get; set; }

        public override System.String Template => TemplateEx;
        public System.String TemplateEx { get; set; }

        public override System.Int32 TimeZoneId => TimeZoneIdEx;
        public System.Int32 TimeZoneIdEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.Double UserCodeMaximumLevel => UserCodeMaximumLevelEx;
        public System.Double UserCodeMaximumLevelEx { get; set; }

        public override System.Double UserCodeWarningLevel => UserCodeWarningLevelEx;
        public System.Double UserCodeWarningLevelEx { get; set; }

        public override System.Int32 WebsCount => WebsCountEx;
        public System.Int32 WebsCountEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.SpoOperation Update()
        {
            return UpdateEx;
        }
        public Microsoft.Online.SharePoint.TenantAdministration.SpoOperation UpdateEx { get; set;}

    }
}

