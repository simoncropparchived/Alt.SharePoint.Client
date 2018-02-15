
namespace Microsoft.SharePoint.Client
{
    public class RecycleBinItemMock
    {


        public override Microsoft.SharePoint.Client.User Author => AuthorEx;
        public Microsoft.SharePoint.Client.User AuthorEx { get; set; }

        public override System.String AuthorEmail => AuthorEmailEx;
        public System.String AuthorEmailEx { get; set; }

        public override System.String AuthorName => AuthorNameEx;
        public System.String AuthorNameEx { get; set; }

        public override Microsoft.SharePoint.Client.User DeletedBy => DeletedByEx;
        public Microsoft.SharePoint.Client.User DeletedByEx { get; set; }

        public override System.String DeletedByEmail => DeletedByEmailEx;
        public System.String DeletedByEmailEx { get; set; }

        public override System.String DeletedByName => DeletedByNameEx;
        public System.String DeletedByNameEx { get; set; }

        public override System.DateTime DeletedDate => DeletedDateEx;
        public System.DateTime DeletedDateEx { get; set; }

        public override System.String DeletedDateLocalFormatted => DeletedDateLocalFormattedEx;
        public System.String DeletedDateLocalFormattedEx { get; set; }

        public override System.String DirName => DirNameEx;
        public System.String DirNameEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath DirNamePath => DirNamePathEx;
        public Microsoft.SharePoint.Client.ResourcePath DirNamePathEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinItemState ItemState => ItemStateEx;
        public Microsoft.SharePoint.Client.RecycleBinItemState ItemStateEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinItemType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.RecycleBinItemType ItemTypeEx { get; set; }

        public override System.String LeafName => LeafNameEx;
        public System.String LeafNameEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath LeafNamePath => LeafNamePathEx;
        public Microsoft.SharePoint.Client.ResourcePath LeafNamePathEx { get; set; }

        public override System.Int64 Size => SizeEx;
        public System.Int64 SizeEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

    }
}

