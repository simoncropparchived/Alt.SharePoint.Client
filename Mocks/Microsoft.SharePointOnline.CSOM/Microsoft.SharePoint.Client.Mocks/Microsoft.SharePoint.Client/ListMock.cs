
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListMock : List
    {


        public override System.Boolean AllowContentTypes => AllowContentTypesEx;
        public System.Boolean AllowContentTypesEx { get; set; }

        public override System.Boolean AllowDeletion => AllowDeletionEx;
        public System.Boolean AllowDeletionEx { get; set; }

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

        public override Microsoft.SharePoint.Client.CustomActionElementCollection CustomActionElements => CustomActionElementsEx;
        public Microsoft.SharePoint.Client.CustomActionElementCollection CustomActionElementsEx { get; set; }

        public override Microsoft.SharePoint.Client.ListDataSource DataSource => DataSourceEx;
        public Microsoft.SharePoint.Client.ListDataSource DataSourceEx { get; set; }

        public override System.Guid DefaultContentApprovalWorkflowId => DefaultContentApprovalWorkflowIdEx;
        public System.Guid DefaultContentApprovalWorkflowIdEx { get; set; }

        public override System.String DefaultDisplayFormUrl => DefaultDisplayFormUrlEx;
        public System.String DefaultDisplayFormUrlEx { get; set; }

        public override System.String DefaultEditFormUrl => DefaultEditFormUrlEx;
        public System.String DefaultEditFormUrlEx { get; set; }

        public override System.Boolean DefaultItemOpenUseListSetting => DefaultItemOpenUseListSettingEx;
        public System.Boolean DefaultItemOpenUseListSettingEx { get; set; }

        public override System.String DefaultNewFormUrl => DefaultNewFormUrlEx;
        public System.String DefaultNewFormUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.View DefaultView => DefaultViewEx;
        public Microsoft.SharePoint.Client.View DefaultViewEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath DefaultViewPath => DefaultViewPathEx;
        public Microsoft.SharePoint.Client.ResourcePath DefaultViewPathEx { get; set; }

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

        public override System.Boolean EnableAssignToEmail => EnableAssignToEmailEx;
        public System.Boolean EnableAssignToEmailEx { get; set; }

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

        public override System.Boolean ExcludeFromOfflineClient => ExcludeFromOfflineClientEx;
        public System.Boolean ExcludeFromOfflineClientEx { get; set; }

        public override System.Boolean ExemptFromBlockDownloadOfNonViewableFiles => ExemptFromBlockDownloadOfNonViewableFilesEx;
        public System.Boolean ExemptFromBlockDownloadOfNonViewableFilesEx { get; set; }

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

        public override Microsoft.SharePoint.Client.ResourcePath ImagePath => ImagePathEx;
        public Microsoft.SharePoint.Client.ResourcePath ImagePathEx { get; set; }

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

        public override System.Boolean IsEnterpriseGalleryLibrary => IsEnterpriseGalleryLibraryEx;
        public System.Boolean IsEnterpriseGalleryLibraryEx { get; set; }

        public override System.Boolean IsPrivate => IsPrivateEx;
        public System.Boolean IsPrivateEx { get; set; }

        public override System.Boolean IsSiteAssetsLibrary => IsSiteAssetsLibraryEx;
        public System.Boolean IsSiteAssetsLibraryEx { get; set; }

        public override System.Boolean IsSystemList => IsSystemListEx;
        public System.Boolean IsSystemListEx { get; set; }

        public override System.Int32 ItemCount => ItemCountEx;
        public System.Int32 ItemCountEx { get; set; }

        public override System.DateTime LastItemDeletedDate => LastItemDeletedDateEx;
        public System.DateTime LastItemDeletedDateEx { get; set; }

        public override System.DateTime LastItemModifiedDate => LastItemModifiedDateEx;
        public System.DateTime LastItemModifiedDateEx { get; set; }

        public override System.DateTime LastItemUserModifiedDate => LastItemUserModifiedDateEx;
        public System.DateTime LastItemUserModifiedDateEx { get; set; }

        public override Microsoft.SharePoint.Client.ListExperience ListExperienceOptions => ListExperienceOptionsEx;
        public Microsoft.SharePoint.Client.ListExperience ListExperienceOptionsEx { get; set; }

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

        public override Microsoft.SharePoint.Client.ListPageRenderType PageRenderType => PageRenderTypeEx;
        public Microsoft.SharePoint.Client.ListPageRenderType PageRenderTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.Web ParentWeb => ParentWebEx;
        public Microsoft.SharePoint.Client.Web ParentWebEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath ParentWebPath => ParentWebPathEx;
        public Microsoft.SharePoint.Client.ResourcePath ParentWebPathEx { get; set; }

        public override System.String ParentWebUrl => ParentWebUrlEx;
        public System.String ParentWebUrlEx { get; set; }

        public override System.Boolean ParserDisabled => ParserDisabledEx;
        public System.Boolean ParserDisabledEx { get; set; }

        public override System.Int32 ReadSecurity => ReadSecurityEx;
        public System.Int32 ReadSecurityEx { get; set; }

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

        public override System.Int32 WriteSecurity => WriteSecurityEx;
        public System.Int32 WriteSecurityEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem GetItemById(System.String @id)
        {
            return GetItemByIdStringEx;
        }
        public Microsoft.SharePoint.Client.ListItem GetItemByIdStringEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem GetItemById(System.Int32 @id)
        {
            return GetItemByIdInt32Ex;
        }
        public Microsoft.SharePoint.Client.ListItem GetItemByIdInt32Ex { get; set;}

        public override Microsoft.SharePoint.Client.ListBloomFilter GetBloomFilter(System.Int32 @startItemId)
        {
            return GetBloomFilterEx;
        }
        public Microsoft.SharePoint.Client.ListBloomFilter GetBloomFilterEx { get; set;}

        public override Microsoft.SharePoint.Client.ListBloomFilter GetBloomFilterWithCustomFields(System.Int32 @listItemStartingID, System.Collections.Generic.IList<System.String> @internalFieldNames)
        {
            return GetBloomFilterWithCustomFieldsEx;
        }
        public Microsoft.SharePoint.Client.ListBloomFilter GetBloomFilterWithCustomFieldsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> SaveAsNewView(System.String @oldName, System.String @newName, System.Boolean @privateView, System.String @uri)
        {
            return SaveAsNewViewEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> SaveAsNewViewEx { get; set;}

        public override Microsoft.SharePoint.Client.View CreateMappedView(Microsoft.SharePoint.Client.AppViewCreationInfo @appViewCreationInfo, Microsoft.SharePoint.Client.VisualizationAppTarget @visualizationTarget)
        {
            return CreateMappedViewEx;
        }
        public Microsoft.SharePoint.Client.View CreateMappedViewEx { get; set;}

        public override Microsoft.SharePoint.Client.VisualizationAppSynchronizationResult ValidateAppName(System.String @appDisplayName)
        {
            return ValidateAppNameEx;
        }
        public Microsoft.SharePoint.Client.VisualizationAppSynchronizationResult ValidateAppNameEx { get; set;}

        public override Microsoft.SharePoint.Client.View PublishMappedView(System.Guid @appId, Microsoft.SharePoint.Client.VisualizationAppTarget @visualizationTarget)
        {
            return PublishMappedViewEx;
        }
        public Microsoft.SharePoint.Client.View PublishMappedViewEx { get; set;}

        public override Microsoft.SharePoint.Client.View UnpublishMappedView(System.Guid @appId, Microsoft.SharePoint.Client.VisualizationAppTarget @visualizationTarget)
        {
            return UnpublishMappedViewEx;
        }
        public Microsoft.SharePoint.Client.View UnpublishMappedViewEx { get; set;}

        public override Microsoft.SharePoint.Client.VisualizationAppSynchronizationResult GetMappedApp(System.Guid @appId, Microsoft.SharePoint.Client.VisualizationAppTarget @visualizationAppTarget)
        {
            return GetMappedAppEx;
        }
        public Microsoft.SharePoint.Client.VisualizationAppSynchronizationResult GetMappedAppEx { get; set;}

        public override Microsoft.SharePoint.Client.VisualizationAppSynchronizationResult GetMappedApps(Microsoft.SharePoint.Client.VisualizationAppTarget @visualizationAppTarget)
        {
            return GetMappedAppsEx;
        }
        public Microsoft.SharePoint.Client.VisualizationAppSynchronizationResult GetMappedAppsEx { get; set;}

        public override Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowTemplates(System.String @category)
        {
            return SyncFlowTemplatesEx;
        }
        public Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowTemplatesEx { get; set;}

        public override Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowInstances()
        {
            return SyncFlowInstancesEx;
        }
        public Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowInstancesEx { get; set;}

        public override Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowInstance(System.Guid @flowID)
        {
            return SyncFlowInstanceEx;
        }
        public Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowInstanceEx { get; set;}

        public override Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowCallbackUrl(System.String @flowId)
        {
            return SyncFlowCallbackUrlEx;
        }
        public Microsoft.SharePoint.Client.FlowSynchronizationResult SyncFlowCallbackUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> CreateDocumentAndGetEditLink(System.String @fileName, System.String @folderPath, System.Int32 @documentTemplateType, System.String @templateUrl)
        {
            return CreateDocumentAndGetEditLinkEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> CreateDocumentAndGetEditLinkEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> CreateDocumentWithDefaultName(System.String @folderPath, System.String @extension)
        {
            return CreateDocumentWithDefaultNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> CreateDocumentWithDefaultNameEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem CreateDocument(System.String @fileName, Microsoft.SharePoint.Client.Folder @targetFolder, Microsoft.SharePoint.Client.DocumentTemplateType @templateType)
        {
            return CreateDocumentEx;
        }
        public Microsoft.SharePoint.Client.ListItem CreateDocumentEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplateStream(System.String @fileName, Microsoft.SharePoint.Client.Folder @targetFolder, System.String @extension, System.IO.Stream @templateStream)
        {
            return CreateDocumentFromTemplateStreamEx;
        }
        public Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplateStreamEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplateBytes(System.String @fileName, Microsoft.SharePoint.Client.Folder @targetFolder, System.Byte[] @templateBytes, System.String @extension)
        {
            return CreateDocumentFromTemplateBytesEx;
        }
        public Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplateBytesEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplate(System.String @fileName, Microsoft.SharePoint.Client.Folder @targetFolder, System.String @templateUrl)
        {
            return CreateDocumentFromTemplateEx;
        }
        public Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplateEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplateUsingPath(Microsoft.SharePoint.Client.ResourcePath @filePath, Microsoft.SharePoint.Client.Folder @targetFolder, Microsoft.SharePoint.Client.ResourcePath @templatePath)
        {
            return CreateDocumentFromTemplateUsingPathEx;
        }
        public Microsoft.SharePoint.Client.ListItem CreateDocumentFromTemplateUsingPathEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetSpecialFolderUrl(Microsoft.SharePoint.Client.SpecialFolderType @type, System.Boolean @bForceCreate, System.Guid @existingFolderGuid)
        {
            return GetSpecialFolderUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetSpecialFolderUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetWebDavUrl(System.String @sourceUrl)
        {
            return GetWebDavUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetWebDavUrlEx { get; set;}

        public override void SaveAsTemplate(System.String @strFileName, System.String @strName, System.String @strDescription, System.Boolean @bSaveData)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Int32> ReserveListItemId()
        {
            return ReserveListItemIdEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Int32> ReserveListItemIdEx { get; set;}

        public override void Update()
        {
        }

        public override Microsoft.SharePoint.Client.View GetView(System.Guid @viewGuid)
        {
            return GetViewEx;
        }
        public Microsoft.SharePoint.Client.View GetViewEx { get; set;}

        public override void DeleteObject()
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Recycle()
        {
            return RecycleEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> RecycleEx { get; set;}

        public override Microsoft.SharePoint.Client.ChangeCollection GetChanges(Microsoft.SharePoint.Client.ChangeQuery @query)
        {
            return GetChangesEx;
        }
        public Microsoft.SharePoint.Client.ChangeCollection GetChangesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.BasePermissions> GetUserEffectivePermissions(System.String @userName)
        {
            return GetUserEffectivePermissionsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.BasePermissions> GetUserEffectivePermissionsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> RenderListFormData(System.Int32 @itemId, System.String @formId, System.Int32 @mode)
        {
            return RenderListFormDataEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> RenderListFormDataEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> RenderListData(System.String @viewXml)
        {
            return RenderListDataEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> RenderListDataEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> RenderListDataAsStream(Microsoft.SharePoint.Client.RenderListDataParameters @parameters, Microsoft.SharePoint.Client.RenderListDataOverrideParameters @overrideParameters)
        {
            return RenderListDataAsStreamEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> RenderListDataAsStreamEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> RenderListFilterData(Microsoft.SharePoint.Client.RenderListFilterDataParameters @parameters)
        {
            return RenderListFilterDataEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> RenderListFilterDataEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> RenderListContextMenuData(Microsoft.SharePoint.Client.RenderListContextMenuDataParameters @parameters)
        {
            return RenderListContextMenuDataEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> RenderListContextMenuDataEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItemCollection GetItems(Microsoft.SharePoint.Client.CamlQuery @query)
        {
            return GetItemsEx;
        }
        public Microsoft.SharePoint.Client.ListItemCollection GetItemsEx { get; set;}

        public override void SetExemptFromBlockDownloadOfNonViewableFiles(System.Boolean @value)
        {
        }

        public override Microsoft.SharePoint.Client.ListItem GetItemByUniqueId(System.Guid @uniqueId)
        {
            return GetItemByUniqueIdEx;
        }
        public Microsoft.SharePoint.Client.ListItem GetItemByUniqueIdEx { get; set;}

        public override Microsoft.SharePoint.Client.RelatedFieldCollection GetRelatedFields()
        {
            return GetRelatedFieldsEx;
        }
        public Microsoft.SharePoint.Client.RelatedFieldCollection GetRelatedFieldsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> RenderExtendedListFormData(System.Int32 @itemId, System.String @formId, System.Int32 @mode, Microsoft.SharePoint.Client.RenderListFormDataOptions @options)
        {
            return RenderExtendedListFormDataEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> RenderExtendedListFormDataEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem AddItem(Microsoft.SharePoint.Client.ListItemCreationInformation @parameters)
        {
            return AddItemEx;
        }
        public Microsoft.SharePoint.Client.ListItem AddItemEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem AddItemUsingPath(Microsoft.SharePoint.Client.ListItemCreationInformationUsingPath @parameters)
        {
            return AddItemUsingPathEx;
        }
        public Microsoft.SharePoint.Client.ListItem AddItemUsingPathEx { get; set;}

    }
}

