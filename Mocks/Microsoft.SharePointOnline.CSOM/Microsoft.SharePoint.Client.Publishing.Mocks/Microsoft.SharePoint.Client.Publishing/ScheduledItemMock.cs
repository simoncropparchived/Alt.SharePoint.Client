
namespace Microsoft.SharePoint.Client.Publishing
{
    public class ScheduledItemMock
    {


        public override System.DateTime EndDate => EndDateEx;
        public System.DateTime EndDateEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem ListItem => ListItemEx;
        public Microsoft.SharePoint.Client.ListItem ListItemEx { get; set; }

        public override System.DateTime StartDate => StartDateEx;
        public System.DateTime StartDateEx { get; set; }

    }
}

