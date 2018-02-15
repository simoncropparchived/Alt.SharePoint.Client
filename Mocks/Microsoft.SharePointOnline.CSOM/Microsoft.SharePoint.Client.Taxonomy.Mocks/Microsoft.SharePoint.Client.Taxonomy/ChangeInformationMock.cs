
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class ChangeInformationMock : ChangeInformation
    {


        public override Microsoft.SharePoint.Client.Taxonomy.ChangedItemType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.Taxonomy.ChangedItemType ItemTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.ChangedOperationType OperationType => OperationTypeEx;
        public Microsoft.SharePoint.Client.Taxonomy.ChangedOperationType OperationTypeEx { get; set; }

        public override System.DateTime StartTime => StartTimeEx;
        public System.DateTime StartTimeEx { get; set; }

        public override System.TimeSpan WithinTimeSpan => WithinTimeSpanEx;
        public System.TimeSpan WithinTimeSpanEx { get; set; }

    }
}

