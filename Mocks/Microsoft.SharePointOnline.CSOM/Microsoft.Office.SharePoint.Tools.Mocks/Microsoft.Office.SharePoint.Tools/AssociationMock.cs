
namespace Microsoft.Office.SharePoint.Tools
{
    public class AssociationMock : Association
    {


        public override Microsoft.Office.SharePoint.Tools.SourceEntity[] SourceEntity => SourceEntityEx;
        public Microsoft.Office.SharePoint.Tools.SourceEntity[] SourceEntityEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.DestinationEntity DestinationEntity => DestinationEntityEx;
        public Microsoft.Office.SharePoint.Tools.DestinationEntity DestinationEntityEx { get; set; }

    }
}

