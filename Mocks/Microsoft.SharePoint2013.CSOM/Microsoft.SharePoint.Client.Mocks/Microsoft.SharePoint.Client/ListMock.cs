
// ReSharper disable IdentifierTypo
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

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

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

        public override Microsoft.SharePoint.Client.ClientResult<System.String> SaveAsNewView(System.String @oldName, System.String @newName, System.Boolean @privateView, System.String @uri)
        {
            return SaveAsNewViewEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> SaveAsNewViewEx { get; set;}

        public override Microsoft.SharePoint.Client.RelatedFieldCollection GetRelatedFields()
        {
            return GetRelatedFieldsEx;
        }
        public Microsoft.SharePoint.Client.RelatedFieldCollection GetRelatedFieldsEx { get; set;}

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

        public override Microsoft.SharePoint.Client.ListItemCollection GetItems(Microsoft.SharePoint.Client.CamlQuery @query)
        {
            return GetItemsEx;
        }
        public Microsoft.SharePoint.Client.ListItemCollection GetItemsEx { get; set;}

        public override Microsoft.SharePoint.Client.ListItem AddItem(Microsoft.SharePoint.Client.ListItemCreationInformation @parameters)
        {
            return AddItemEx;
        }
        public Microsoft.SharePoint.Client.ListItem AddItemEx { get; set;}

    }
}

