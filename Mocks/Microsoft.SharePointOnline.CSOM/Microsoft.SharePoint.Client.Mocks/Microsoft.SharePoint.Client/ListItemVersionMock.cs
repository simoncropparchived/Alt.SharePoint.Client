
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListItemVersionMock : ListItemVersion
    {


        public override System.Collections.Generic.Dictionary<System.String, System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String, System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override Microsoft.SharePoint.Client.User CreatedBy => CreatedByEx;
        public Microsoft.SharePoint.Client.User CreatedByEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldCollection Fields => FieldsEx;
        public Microsoft.SharePoint.Client.FieldCollection FieldsEx { get; set; }

        public override Microsoft.SharePoint.Client.FileVersion FileVersion => FileVersionEx;
        public Microsoft.SharePoint.Client.FileVersion FileVersionEx { get; set; }

        public override System.Boolean IsCurrentVersion => IsCurrentVersionEx;
        public System.Boolean IsCurrentVersionEx { get; set; }

        public override System.Int32 VersionId => VersionIdEx;
        public System.Int32 VersionIdEx { get; set; }

        public override System.String VersionLabel => VersionLabelEx;
        public System.String VersionLabelEx { get; set; }

        public override void RefreshLoad()
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

