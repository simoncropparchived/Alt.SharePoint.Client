
namespace Microsoft.SharePoint.Client
{
    public class EffectiveInformationRightsManagementSettingsMock : EffectiveInformationRightsManagementSettings
    {


        public override System.Boolean AllowPrint => AllowPrintEx;
        public System.Boolean AllowPrintEx { get; set; }

        public override System.Boolean AllowScript => AllowScriptEx;
        public System.Boolean AllowScriptEx { get; set; }

        public override System.Boolean AllowWriteCopy => AllowWriteCopyEx;
        public System.Boolean AllowWriteCopyEx { get; set; }

        public override System.Boolean DisableDocumentBrowserView => DisableDocumentBrowserViewEx;
        public System.Boolean DisableDocumentBrowserViewEx { get; set; }

        public override System.Int32 DocumentAccessExpireDays => DocumentAccessExpireDaysEx;
        public System.Int32 DocumentAccessExpireDaysEx { get; set; }

        public override System.DateTime DocumentLibraryProtectionExpireDate => DocumentLibraryProtectionExpireDateEx;
        public System.DateTime DocumentLibraryProtectionExpireDateEx { get; set; }

        public override System.Boolean EnableDocumentAccessExpire => EnableDocumentAccessExpireEx;
        public System.Boolean EnableDocumentAccessExpireEx { get; set; }

        public override System.Boolean EnableDocumentBrowserPublishingView => EnableDocumentBrowserPublishingViewEx;
        public System.Boolean EnableDocumentBrowserPublishingViewEx { get; set; }

        public override System.Boolean EnableGroupProtection => EnableGroupProtectionEx;
        public System.Boolean EnableGroupProtectionEx { get; set; }

        public override System.Boolean EnableLicenseCacheExpire => EnableLicenseCacheExpireEx;
        public System.Boolean EnableLicenseCacheExpireEx { get; set; }

        public override System.String GroupName => GroupNameEx;
        public System.String GroupNameEx { get; set; }

        public override System.Boolean IrmEnabled => IrmEnabledEx;
        public System.Boolean IrmEnabledEx { get; set; }

        public override System.Int32 LicenseCacheExpireDays => LicenseCacheExpireDaysEx;
        public System.Int32 LicenseCacheExpireDaysEx { get; set; }

        public override System.String PolicyDescription => PolicyDescriptionEx;
        public System.String PolicyDescriptionEx { get; set; }

        public override System.String PolicyTitle => PolicyTitleEx;
        public System.String PolicyTitleEx { get; set; }

        public override Microsoft.SharePoint.Client.SPEffectiveInformationRightsManagementSettingsSource SettingSource => SettingSourceEx;
        public Microsoft.SharePoint.Client.SPEffectiveInformationRightsManagementSettingsSource SettingSourceEx { get; set; }

        public override System.String TemplateId => TemplateIdEx;
        public System.String TemplateIdEx { get; set; }

    }
}

