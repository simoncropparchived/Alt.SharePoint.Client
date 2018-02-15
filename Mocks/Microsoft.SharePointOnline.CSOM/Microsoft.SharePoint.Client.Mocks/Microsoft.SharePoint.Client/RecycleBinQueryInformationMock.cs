
namespace Microsoft.SharePoint.Client
{
    public class RecycleBinQueryInformationMock : RecycleBinQueryInformation
    {


        public override System.Boolean IsAscending => IsAscendingEx;
        public System.Boolean IsAscendingEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinItemState ItemState => ItemStateEx;
        public Microsoft.SharePoint.Client.RecycleBinItemState ItemStateEx { get; set; }

        public override Microsoft.SharePoint.Client.RecycleBinOrderBy OrderBy => OrderByEx;
        public Microsoft.SharePoint.Client.RecycleBinOrderBy OrderByEx { get; set; }

        public override System.String PagingInfo => PagingInfoEx;
        public System.String PagingInfoEx { get; set; }

        public override System.Int32 RowLimit => RowLimitEx;
        public System.Int32 RowLimitEx { get; set; }

        public override System.Boolean ShowOnlyMyItems => ShowOnlyMyItemsEx;
        public System.Boolean ShowOnlyMyItemsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

