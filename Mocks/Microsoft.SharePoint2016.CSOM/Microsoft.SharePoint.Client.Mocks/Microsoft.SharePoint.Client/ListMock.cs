
namespace Microsoft.SharePoint.Client
{
    public class ListMock : List
    {


        public override System.Boolean AllowContentTypes => AllowContentTypesEx;
        public System.Boolean AllowContentTypesEx { get; set; }

        public override System.Int32 BaseTemplate => BaseTemplateEx;
        public System.Int32 BaseTemplateEx { get; set; }

        public override Microsoft.SharePoint.Client.BaseType BaseType => BaseTypeEx;
        public Microsoft.SharePoint.Client.BaseType BaseTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.BrowserFileHandling BrowserFileHandling => BrowserFileHandlingEx;
        public Microsoft.SharePoint.Client.BrowserFileHandling BrowserFileHandlingEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentTypeCollection ContentTypes => ContentTypesEx;
        public Microsoft.SharePoint.Client.ContentTypeCollection ContentTypesEx { get; set; }

        public override System.Boolean ContentTypesEnabled => ContentTypesEnabledEx;
        public System.Boolean ContentTypesEnabledEx { get; set; }

        public override System.Boolean CrawlNonDefaultViews => CrawlNonDefaultViewsEx;
        public System.Boolean CrawlNonDefaultViewsEx { get; set; }

        public override Microsoft.SharePoint.Client.CreatablesInfo CreatablesInfo => CreatablesInfoEx;
        public Microsoft.SharePoint.Client.CreatablesInfo CreatablesInfoEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override Microsoft.SharePoint.Client.ChangeToken CurrentChangeToken => CurrentChangeTokenEx;
        public Microsoft.SharePoint.Client.ChangeToken CurrentChangeTokenEx { get; set; }

        public override Microsoft.SharePoint.Client.ListDataSource DataSource => DataSourceEx;
        public Microsoft.SharePoint.Client.ListDataSource DataSourceEx { get; set; }

        public override System.Guid DefaultContentApprovalWorkflowId => DefaultContentApprovalWorkflowIdEx;
        public System.Guid DefaultContentApprovalWorkflowIdEx { get; set; }

        public override System.String DefaultDisplayFormUrl => DefaultDisplayFormUrlEx;
        public System.String DefaultDisplayFormUrlEx { get; set; }

        public override System.String DefaultEditFormUrl => DefaultEditFormUrlEx;
        public System.String DefaultEditFormUrlEx { get; set; }

        public override System.String DefaultNewFormUrl => DefaultNewFormUrlEx;
        public System.String DefaultNewFormUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.View DefaultView => DefaultViewEx;
        public Microsoft.SharePoint.Client.View DefaultViewEx { get; set; }

        public override System.String DefaultViewUrl => DefaultViewUrlEx;
        public System.String DefaultViewUrlEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource DescriptionResource => DescriptionResourceEx;
        public Microsoft.SharePoint.Client.UserResource DescriptionResourceEx { get; set; }

        public override System.String Direction => DirectionEx;
        public System.String DirectionEx { get; set; }

        public override System.String DocumentTemplateUrl => DocumentTemplateUrlEx;
        public System.String DocumentTemplateUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.DraftVisibilityType DraftVersionVisibility => DraftVersionVisibilityEx;
        public Microsoft.SharePoint.Client.DraftVisibilityType DraftVersionVisibilityEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissions => EffectiveBasePermissionsEx;
        public Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsForUI => EffectiveBasePermissionsForUIEx;
        public Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsForUIEx { get; set; }

        public override System.Boolean EnableAttachments => EnableAttachmentsEx;
        public System.Boolean EnableAttachmentsEx { get; set; }

        public override System.Boolean EnableFolderCreation => EnableFolderCreationEx;
        public System.Boolean EnableFolderCreationEx { get; set; }

        public override System.Boolean EnableMinorVersions => EnableMinorVersionsEx;
        public System.Boolean EnableMinorVersionsEx { get; set; }

        public override System.Boolean EnableModeration => EnableModerationEx;
        public System.Boolean EnableModerationEx { get; set; }

        public override System.Boolean EnableVersioning => EnableVersioningEx;
        public System.Boolean EnableVersioningEx { get; set; }

        public override System.String EntityTypeName => EntityTypeNameEx;
        public System.String EntityTypeNameEx { get; set; }

        public override Microsoft.SharePoint.Client.EventReceiverDefinitionCollection EventReceivers => EventReceiversEx;
        public Microsoft.SharePoint.Client.EventReceiverDefinitionCollection EventReceiversEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldCollection Fields => FieldsEx;
        public Microsoft.SharePoint.Client.FieldCollection FieldsEx { get; set; }

        public override System.Boolean FileSavePostProcessingEnabled => FileSavePostProcessingEnabledEx;
        public System.Boolean FileSavePostProcessingEnabledEx { get; set; }

        public override System.Boolean ForceCheckout => ForceCheckoutEx;
        public System.Boolean ForceCheckoutEx { get; set; }

        public override Microsoft.SharePoint.Client.FormCollection Forms => FormsEx;
        public Microsoft.SharePoint.Client.FormCollection FormsEx { get; set; }

        public override System.Boolean HasExternalDataSource => HasExternalDataSourceEx;
        public System.Boolean HasExternalDataSourceEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String ImageUrl => ImageUrlEx;
        public System.String ImageUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.InformationRightsManagementSettings InformationRightsManagementSettings => InformationRightsManagementSettingsEx;
        public Microsoft.SharePoint.Client.InformationRightsManagementSettings InformationRightsManagementSettingsEx { get; set; }

        public override System.Boolean IrmEnabled => IrmEnabledEx;
        public System.Boolean IrmEnabledEx { get; set; }

        public override System.Boolean IrmExpire => IrmExpireEx;
        public System.Boolean IrmExpireEx { get; set; }

        public override System.Boolean IrmReject => IrmRejectEx;
        public System.Boolean IrmRejectEx { get; set; }

        public override System.Boolean IsApplicationList => IsApplicationListEx;
        public System.Boolean IsApplicationListEx { get; set; }

        public override System.Boolean IsCatalog => IsCatalogEx;
        public System.Boolean IsCatalogEx { get; set; }

        public override System.Boolean IsPrivate => IsPrivateEx;
        public System.Boolean IsPrivateEx { get; set; }

        public override System.Boolean IsSiteAssetsLibrary => IsSiteAssetsLibraryEx;
        public System.Boolean IsSiteAssetsLibraryEx { get; set; }

        public override System.Int32 ItemCount => ItemCountEx;
        public System.Int32 ItemCountEx { get; set; }

        public override System.DateTime LastItemDeletedDate => LastItemDeletedDateEx;
        public System.DateTime LastItemDeletedDateEx { get; set; }

        public override System.DateTime LastItemModifiedDate => LastItemModifiedDateEx;
        public System.DateTime LastItemModifiedDateEx { get; set; }

        public override System.String ListItemEntityTypeFullName => ListItemEntityTypeFullNameEx;
        public System.String ListItemEntityTypeFullNameEx { get; set; }

        public override System.Int32 MajorVersionLimit => MajorVersionLimitEx;
        public System.Int32 MajorVersionLimitEx { get; set; }

        public override System.Int32 MajorWithMinorVersionsLimit => MajorWithMinorVersionsLimitEx;
        public System.Int32 MajorWithMinorVersionsLimitEx { get; set; }

        public override System.Boolean MultipleDataList => MultipleDataListEx;
        public System.Boolean MultipleDataListEx { get; set; }

        public override System.Boolean NoCrawl => NoCrawlEx;
        public System.Boolean NoCrawlEx { get; set; }

        public override System.Boolean OnQuickLaunch => OnQuickLaunchEx;
        public System.Boolean OnQuickLaunchEx { get; set; }

        public override Microsoft.SharePoint.Client.Web ParentWeb => ParentWebEx;
        public Microsoft.SharePoint.Client.Web ParentWebEx { get; set; }

        public override System.String ParentWebUrl => ParentWebUrlEx;
        public System.String ParentWebUrlEx { get; set; }

        public override System.Boolean ParserDisabled => ParserDisabledEx;
        public System.Boolean ParserDisabledEx { get; set; }

        public override Microsoft.SharePoint.Client.Folder RootFolder => RootFolderEx;
        public Microsoft.SharePoint.Client.Folder RootFolderEx { get; set; }

        public override System.String SchemaXml => SchemaXmlEx;
        public System.String SchemaXmlEx { get; set; }

        public override System.Boolean ServerTemplateCanCreateFolders => ServerTemplateCanCreateFoldersEx;
        public System.Boolean ServerTemplateCanCreateFoldersEx { get; set; }

        public override System.Guid TemplateFeatureId => TemplateFeatureIdEx;
        public System.Guid TemplateFeatureIdEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override Microsoft.SharePoint.Client.UserResource TitleResource => TitleResourceEx;
        public Microsoft.SharePoint.Client.UserResource TitleResourceEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCustomActionCollection UserCustomActions => UserCustomActionsEx;
        public Microsoft.SharePoint.Client.UserCustomActionCollection UserCustomActionsEx { get; set; }

        public override System.String ValidationFormula => ValidationFormulaEx;
        public System.String ValidationFormulaEx { get; set; }

        public override System.String ValidationMessage => ValidationMessageEx;
        public System.String ValidationMessageEx { get; set; }

        public override Microsoft.SharePoint.Client.ViewCollection Views => ViewsEx;
        public Microsoft.SharePoint.Client.ViewCollection ViewsEx { get; set; }

        public override Microsoft.SharePoint.Client.Workflow.WorkflowAssociationCollection WorkflowAssociations => WorkflowAssociationsEx;
        public Microsoft.SharePoint.Client.Workflow.WorkflowAssociationCollection WorkflowAssociationsEx { get; set; }

    }
}

