
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class ChangedItemMock : ChangedItem
    {


        public override System.String ChangedBy => ChangedByEx;
        public System.String ChangedByEx { get; set; }

        public override System.DateTime ChangedTime => ChangedTimeEx;
        public System.DateTime ChangedTimeEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.ChangedItemType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.Taxonomy.ChangedItemType ItemTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.ChangedOperationType Operation => OperationEx;
        public Microsoft.SharePoint.Client.Taxonomy.ChangedOperationType OperationEx { get; set; }

    }
}

