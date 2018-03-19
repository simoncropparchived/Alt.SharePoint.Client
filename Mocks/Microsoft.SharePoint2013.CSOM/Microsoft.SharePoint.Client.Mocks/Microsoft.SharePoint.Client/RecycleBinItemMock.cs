
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RecycleBinItemMock : RecycleBinItem
    {


        public override Microsoft.SharePoint.Client.User Author => AuthorEx;
        public Microsoft.SharePoint.Client.User AuthorEx { get; set; }

        public override Microsoft.SharePoint.Client.User DeletedBy => DeletedByEx;
        public Microsoft.SharePoint.Client.User DeletedByEx { get; set; }

        public override System.DateTime DeletedDate => DeletedDateEx;
        public System.DateTime DeletedDateEx { get; set; }

        public override System.String DirName => DirNameEx;
        public System.String DirNameEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinItemState ItemState => ItemStateEx;
        public Microsoft.SharePoint.Client.RecycleBinItemState ItemStateEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinItemType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.RecycleBinItemType ItemTypeEx { get; set; }

        public override System.String LeafName => LeafNameEx;
        public System.String LeafNameEx { get; set; }

        public override System.Int64 Size => SizeEx;
        public System.Int64 SizeEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override void DeleteObject()
        {
        }

        public override void Restore()
        {
        }

    }
}

