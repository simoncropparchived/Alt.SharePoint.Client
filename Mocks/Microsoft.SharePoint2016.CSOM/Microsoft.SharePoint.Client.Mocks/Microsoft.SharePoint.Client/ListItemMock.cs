
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListItemMock : ListItem
    {


        public override System.Collections.Generic.Dictionary<System.String, System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String, System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override Microsoft.SharePoint.Client.AttachmentCollection AttachmentFiles => AttachmentFilesEx;
        public Microsoft.SharePoint.Client.AttachmentCollection AttachmentFilesEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentType ContentType => ContentTypeEx;
        public Microsoft.SharePoint.Client.ContentType ContentTypeEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override Microsoft.SharePoint.Client.DlpPolicyTip GetDlpPolicyTip => GetDlpPolicyTipEx;
        public Microsoft.SharePoint.Client.DlpPolicyTip GetDlpPolicyTipEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissions => EffectiveBasePermissionsEx;
        public Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsEx { get; set; }

        public override Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsForUI => EffectiveBasePermissionsForUIEx;
        public Microsoft.SharePoint.Client.BasePermissions EffectiveBasePermissionsForUIEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsHtml => FieldValuesAsHtmlEx;
        public Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsHtmlEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsText => FieldValuesAsTextEx;
        public Microsoft.SharePoint.Client.FieldStringValues FieldValuesAsTextEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldStringValues FieldValuesForEdit => FieldValuesForEditEx;
        public Microsoft.SharePoint.Client.FieldStringValues FieldValuesForEditEx { get; set; }

        public override Microsoft.SharePoint.Client.File File => FileEx;
        public Microsoft.SharePoint.Client.File FileEx { get; set; }

        public override Microsoft.SharePoint.Client.FileSystemObjectType FileSystemObjectType => FileSystemObjectTypeEx;
        public Microsoft.SharePoint.Client.FileSystemObjectType FileSystemObjectTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.Folder Folder => FolderEx;
        public Microsoft.SharePoint.Client.Folder FolderEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override Microsoft.SharePoint.Client.List ParentList => ParentListEx;
        public Microsoft.SharePoint.Client.List ParentListEx { get; set; }

        public override System.String Client_Title => Client_TitleEx;
        public System.String Client_TitleEx { get; set; }

        public override void RefreshLoad()
        {
        }

        public override void DeleteObject()
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> Recycle()
        {
            return RecycleEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> RecycleEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.BasePermissions> GetUserEffectivePermissions(System.String @userName)
        {
            return GetUserEffectivePermissionsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.BasePermissions> GetUserEffectivePermissionsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.PolicyTipUserActionResult> OverridePolicyTip(Microsoft.SharePoint.Client.PolicyTipUserAction @userAction, System.String @justification)
        {
            return OverridePolicyTipEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.PolicyTipUserActionResult> OverridePolicyTipEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetWOPIFrameUrl(Microsoft.SharePoint.Client.Utilities.SPWOPIFrameAction @action)
        {
            return GetWOPIFrameUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetWOPIFrameUrlEx { get; set;}

        public override void Update()
        {
        }

        public override Microsoft.SharePoint.Client.ChangeCollection GetChanges(Microsoft.SharePoint.Client.ChangeQuery @query)
        {
            return GetChangesEx;
        }
        public Microsoft.SharePoint.Client.ChangeCollection GetChangesEx { get; set;}

        public override void ParseAndSetFieldValue(System.String @fieldName, System.String @value)
        {
        }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.ListItemFormUpdateValue> ValidateUpdateListItem(System.Collections.Generic.IList<Microsoft.SharePoint.Client.ListItemFormUpdateValue> @formValues, System.Boolean @bNewDocumentUpdate, System.String @checkInComment)
        {
            return ValidateUpdateListItemEx;
        }
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.ListItemFormUpdateValue> ValidateUpdateListItemEx { get; set;}

    }
}

