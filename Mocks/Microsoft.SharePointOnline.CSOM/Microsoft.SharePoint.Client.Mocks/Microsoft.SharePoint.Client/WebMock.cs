
namespace Microsoft.SharePoint.Client
{
    public class WebMock : Web
    {


        public override Microsoft.SharePoint.Client.AlertCollection Alerts => AlertsEx;
        public Microsoft.SharePoint.Client.AlertCollection AlertsEx { get; set; }

        public override System.Boolean AllowAutomaticASPXPageIndexing => AllowAutomaticASPXPageIndexingEx;
        public System.Boolean AllowAutomaticASPXPageIndexingEx { get; set; }

        public override System.Boolean AllowCreateDeclarativeWorkflowForCurrentUser => AllowCreateDeclarativeWorkflowForCurrentUserEx;
        public System.Boolean AllowCreateDeclarativeWorkflowForCurrentUserEx { get; set; }

        public override System.Boolean AllowDesignerForCurrentUser => AllowDesignerForCurrentUserEx;
        public System.Boolean AllowDesignerForCurrentUserEx { get; set; }

        public override System.Boolean AllowMasterPageEditingForCurrentUser => AllowMasterPageEditingForCurrentUserEx;
        public System.Boolean AllowMasterPageEditingForCurrentUserEx { get; set; }

        public override System.Boolean AllowRevertFromTemplateForCurrentUser => AllowRevertFromTemplateForCurrentUserEx;
        public System.Boolean AllowRevertFromTemplateForCurrentUserEx { get; set; }

        public override System.Boolean AllowRssFeeds => AllowRssFeedsEx;
        public System.Boolean AllowRssFeedsEx { get; set; }

        public override System.Boolean AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser => AllowSaveDeclarativeWorkflowAsTemplateForCurrentUserEx;
        public System.Boolean AllowSaveDeclarativeWorkflowAsTemplateForCurrentUserEx { get; set; }

        public override System.Boolean AllowSavePublishDeclarativeWorkflowForCurrentUser => AllowSavePublishDeclarativeWorkflowForCurrentUserEx;
        public System.Boolean AllowSavePublishDeclarativeWorkflowForCurrentUserEx { get; set; }

        public override Microsoft.SharePoint.Client.PropertyValues AllProperties => AllPropertiesEx;
        public Microsoft.SharePoint.Client.PropertyValues AllPropertiesEx { get; set; }

        public override System.String AlternateCssUrl => AlternateCssUrlEx;
        public System.String AlternateCssUrlEx { get; set; }

        public override System.Guid AppInstanceId => AppInstanceIdEx;
        public System.Guid AppInstanceIdEx { get; set; }

        public override Microsoft.SharePoint.Client.AppTileCollection AppTiles => AppTilesEx;
        public Microsoft.SharePoint.Client.AppTileCollection AppTilesEx { get; set; }

        public override Microsoft.SharePoint.Client.Group AssociatedMemberGroup => AssociatedMemberGroupEx;
        public Microsoft.SharePoint.Client.Group AssociatedMemberGroupEx { get; set; }

        public override Microsoft.SharePoint.Client.Group AssociatedOwnerGroup => AssociatedOwnerGroupEx;
        public Microsoft.SharePoint.Client.Group AssociatedOwnerGroupEx { get; set; }

        public override Microsoft.SharePoint.Client.Group AssociatedVisitorGroup => AssociatedVisitorGroupEx;
        public Microsoft.SharePoint.Client.Group AssociatedVisitorGroupEx { get; set; }

        public override Microsoft.SharePoint.Client.User Author => AuthorEx;
        public Microsoft.SharePoint.Client.User AuthorEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentTypeCollection AvailableContentTypes => AvailableContentTypesEx;
        public Microsoft.SharePoint.Client.ContentTypeCollection AvailableContentTypesEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldCollection AvailableFields => AvailableFieldsEx;
        public Microsoft.SharePoint.Client.FieldCollection AvailableFieldsEx { get; set; }

        public override System.Boolean CommentsOnSitePagesDisabled => CommentsOnSitePagesDisabledEx;
        public System.Boolean CommentsOnSitePagesDisabledEx { get; set; }

        public override System.Int16 Configuration => ConfigurationEx;
        public System.Int16 ConfigurationEx { get; set; }

        public override System.Boolean ContainsConfidentialInfo => ContainsConfidentialInfoEx;
        public System.Boolean ContainsConfidentialInfoEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentTypeCollection ContentTypes => ContentTypesEx;
        public Microsoft.SharePoint.Client.ContentTypeCollection ContentTypesEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override Microsoft.SharePoint.Client.ChangeToken CurrentChangeToken => CurrentChangeTokenEx;
        public Microsoft.SharePoint.Client.ChangeToken CurrentChangeTokenEx { get; set; }

        public override Microsoft.SharePoint.Client.User CurrentUser => CurrentUserEx;
        public Microsoft.SharePoint.Client.User CurrentUserEx { get; set; }

        public override System.String CustomMasterUrl => CustomMasterUrlEx;
        public System.String CustomMasterUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.SPDataLeakagePreventionStatusInfo DataLeakagePreventionStatusInfo => DataLeakagePreventionStatusInfoEx;
        public Microsoft.SharePoint.Client.SPDataLeakagePreventionStatusInfo DataLeakagePreventionStatusInfoEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource DescriptionResource => DescriptionResourceEx;
        public Microsoft.SharePoint.Client.UserResource DescriptionResourceEx { get; set; }

        public override System.String DesignerDownloadUrlForCurrentUser => DesignerDownloadUrlForCurrentUserEx;
        public System.String DesignerDownloadUrlForCurrentUserEx { get; set; }

        public override System.Guid DesignPackageId => DesignPackageIdEx;
        public System.Guid DesignPackageIdEx { get; set; }

        public override System.Boolean DisableAppViews => DisableAppViewsEx;
        public System.Boolean DisableAppViewsEx { get; set; }

        public override System.Boolean DisableFlows => DisableFlowsEx;
        public System.Boolean DisableFlowsEx { get; set; }

        public override System.Boolean DocumentLibraryCalloutOfficeWebAppPreviewersDisabled => DocumentLibraryCalloutOfficeWebAppPreviewersDisabledEx;
        public System.Boolean DocumentLibraryCalloutOfficeWebAppPreviewersDisabledEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissions => EffectiveBasePermissionsEx;
        public Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsEx { get; set; }

        public override System.Boolean EnableMinimalDownload => EnableMinimalDownloadEx;
        public System.Boolean EnableMinimalDownloadEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceiverDefinitionCollection EventReceivers => EventReceiversEx;
        public Microsoft.SharePoint.Client.EventReceiverDefinitionCollection EventReceiversEx { get; set; }

        public override System.Boolean ExcludeFromOfflineClient => ExcludeFromOfflineClientEx;
        public System.Boolean ExcludeFromOfflineClientEx { get; set; }

        public override Microsoft.SharePoint.Client.FeatureCollection Features => FeaturesEx;
        public Microsoft.SharePoint.Client.FeatureCollection FeaturesEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldCollection Fields => FieldsEx;
        public Microsoft.SharePoint.Client.FieldCollection FieldsEx { get; set; }

        public override Microsoft.SharePoint.Client.FolderCollection Folders => FoldersEx;
        public Microsoft.SharePoint.Client.FolderCollection FoldersEx { get; set; }

        public override System.Boolean HorizontalQuickLaunch => HorizontalQuickLaunchEx;
        public System.Boolean HorizontalQuickLaunchEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsMultilingual => IsMultilingualEx;
        public System.Boolean IsMultilingualEx { get; set; }

        public override System.UInt32 Language => LanguageEx;
        public System.UInt32 LanguageEx { get; set; }

        public override System.DateTime LastItemModifiedDate => LastItemModifiedDateEx;
        public System.DateTime LastItemModifiedDateEx { get; set; }

        public override System.DateTime LastItemUserModifiedDate => LastItemUserModifiedDateEx;
        public System.DateTime LastItemUserModifiedDateEx { get; set; }

        public override Microsoft.SharePoint.Client.ListCollection Lists => ListsEx;
        public Microsoft.SharePoint.Client.ListCollection ListsEx { get; set; }

        public override Microsoft.SharePoint.Client.ListTemplateCollection ListTemplates => ListTemplatesEx;
        public Microsoft.SharePoint.Client.ListTemplateCollection ListTemplatesEx { get; set; }

        public override System.String MasterUrl => MasterUrlEx;
        public System.String MasterUrlEx { get; set; }

        public override System.Boolean MembersCanShare => MembersCanShareEx;
        public System.Boolean MembersCanShareEx { get; set; }

        public override Microsoft.SharePoint.Client.Navigation Navigation => NavigationEx;
        public Microsoft.SharePoint.Client.Navigation NavigationEx { get; set; }

        public override System.Boolean NoCrawl => NoCrawlEx;
        public System.Boolean NoCrawlEx { get; set; }

        public override System.Boolean NotificationsInOneDriveForBusinessEnabled => NotificationsInOneDriveForBusinessEnabledEx;
        public System.Boolean NotificationsInOneDriveForBusinessEnabledEx { get; set; }

        public override System.Boolean NotificationsInSharePointEnabled => NotificationsInSharePointEnabledEx;
        public System.Boolean NotificationsInSharePointEnabledEx { get; set; }

        public override System.Boolean OverwriteTranslationsOnChange => OverwriteTranslationsOnChangeEx;
        public System.Boolean OverwriteTranslationsOnChangeEx { get; set; }

        public override Microsoft.SharePoint.Client.WebInformation ParentWeb => ParentWebEx;
        public Microsoft.SharePoint.Client.WebInformation ParentWebEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath ResourcePath => ResourcePathEx;
        public Microsoft.SharePoint.Client.ResourcePath ResourcePathEx { get; set; }

        public override System.Boolean PreviewFeaturesEnabled => PreviewFeaturesEnabledEx;
        public System.Boolean PreviewFeaturesEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.PushNotificationSubscriberCollection PushNotificationSubscribers => PushNotificationSubscribersEx;
        public Microsoft.SharePoint.Client.PushNotificationSubscriberCollection PushNotificationSubscribersEx { get; set; }

        public override System.Boolean QuickLaunchEnabled => QuickLaunchEnabledEx;
        public System.Boolean QuickLaunchEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinItemCollection RecycleBin => RecycleBinEx;
        public Microsoft.SharePoint.Client.RecycleBinItemCollection RecycleBinEx { get; set; }

        public override System.Boolean RecycleBinEnabled => RecycleBinEnabledEx;
        public System.Boolean RecycleBinEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.RegionalSettings RegionalSettings => RegionalSettingsEx;
        public Microsoft.SharePoint.Client.RegionalSettings RegionalSettingsEx { get; set; }

        public override System.String RequestAccessEmail => RequestAccessEmailEx;
        public System.String RequestAccessEmailEx { get; set; }

        public override Microsoft.SharePoint.Client.RoleDefinitionCollection RoleDefinitions => RoleDefinitionsEx;
        public Microsoft.SharePoint.Client.RoleDefinitionCollection RoleDefinitionsEx { get; set; }

        public override Microsoft.SharePoint.Client.Folder RootFolder => RootFolderEx;
        public Microsoft.SharePoint.Client.Folder RootFolderEx { get; set; }

        public override System.Boolean SaveSiteAsTemplateEnabled => SaveSiteAsTemplateEnabledEx;
        public System.Boolean SaveSiteAsTemplateEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath ServerRelativePath => ServerRelativePathEx;
        public Microsoft.SharePoint.Client.ResourcePath ServerRelativePathEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.Boolean ShowUrlStructureForCurrentUser => ShowUrlStructureForCurrentUserEx;
        public System.Boolean ShowUrlStructureForCurrentUserEx { get; set; }

        public override Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionCorporateCatalogAccessor SiteCollectionAppCatalog => SiteCollectionAppCatalogEx;
        public Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionCorporateCatalogAccessor SiteCollectionAppCatalogEx { get; set; }

        public override Microsoft.SharePoint.Client.GroupCollection SiteGroups => SiteGroupsEx;
        public Microsoft.SharePoint.Client.GroupCollection SiteGroupsEx { get; set; }

        public override System.String SiteLogoDescription => SiteLogoDescriptionEx;
        public System.String SiteLogoDescriptionEx { get; set; }

        public override System.String SiteLogoUrl => SiteLogoUrlEx;
        public System.String SiteLogoUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.List SiteUserInfoList => SiteUserInfoListEx;
        public Microsoft.SharePoint.Client.List SiteUserInfoListEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCollection SiteUsers => SiteUsersEx;
        public Microsoft.SharePoint.Client.UserCollection SiteUsersEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.Int32> SupportedUILanguageIds => SupportedUILanguageIdsEx;
        public System.Collections.Generic.IEnumerable<System.Int32> SupportedUILanguageIdsEx { get; set; }

        public override System.Boolean SyndicationEnabled => SyndicationEnabledEx;
        public System.Boolean SyndicationEnabledEx { get; set; }

        public override Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.TenantCorporateCatalogAccessor TenantAppCatalog => TenantAppCatalogEx;
        public Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.TenantCorporateCatalogAccessor TenantAppCatalogEx { get; set; }

        public override System.Boolean TenantTagPolicyEnabled => TenantTagPolicyEnabledEx;
        public System.Boolean TenantTagPolicyEnabledEx { get; set; }

        public override System.String ThemedCssFolderUrl => ThemedCssFolderUrlEx;
        public System.String ThemedCssFolderUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ThemeInfo ThemeInfo => ThemeInfoEx;
        public Microsoft.SharePoint.Client.ThemeInfo ThemeInfoEx { get; set; }

        public override System.Boolean ThirdPartyMdmEnabled => ThirdPartyMdmEnabledEx;
        public System.Boolean ThirdPartyMdmEnabledEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource TitleResource => TitleResourceEx;
        public Microsoft.SharePoint.Client.UserResource TitleResourceEx { get; set; }

        public override System.Boolean TreeViewEnabled => TreeViewEnabledEx;
        public System.Boolean TreeViewEnabledEx { get; set; }

        public override System.Int32 UIVersion => UIVersionEx;
        public System.Int32 UIVersionEx { get; set; }

        public override System.Boolean UIVersionConfigurationEnabled => UIVersionConfigurationEnabledEx;
        public System.Boolean UIVersionConfigurationEnabledEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCustomActionCollection UserCustomActions => UserCustomActionsEx;
        public Microsoft.SharePoint.Client.UserCustomActionCollection UserCustomActionsEx { get; set; }

        public override Microsoft.SharePoint.Client.WebCollection Webs => WebsEx;
        public Microsoft.SharePoint.Client.WebCollection WebsEx { get; set; }

        public override System.String WebTemplate => WebTemplateEx;
        public System.String WebTemplateEx { get; set; }

        public override Microsoft.SharePoint.Client.Workflow.WorkflowAssociationCollection WorkflowAssociations => WorkflowAssociationsEx;
        public Microsoft.SharePoint.Client.Workflow.WorkflowAssociationCollection WorkflowAssociationsEx { get; set; }

        public override Microsoft.SharePoint.Client.Workflow.WorkflowTemplateCollection WorkflowTemplates => WorkflowTemplatesEx;
        public Microsoft.SharePoint.Client.Workflow.WorkflowTemplateCollection WorkflowTemplatesEx { get; set; }

    }
}

