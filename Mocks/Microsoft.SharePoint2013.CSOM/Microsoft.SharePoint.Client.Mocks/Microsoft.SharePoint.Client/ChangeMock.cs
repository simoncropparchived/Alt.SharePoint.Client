
namespace Microsoft.SharePoint.Client
{
    public class ChangeMock : Change
    {


        public override Microsoft.SharePoint.Client.ChangeToken ChangeToken => ChangeTokenEx;
        public Microsoft.SharePoint.Client.ChangeToken ChangeTokenEx { get; set; }

        public override Microsoft.SharePoint.Client.ChangeType ChangeType => ChangeTypeEx;
        public Microsoft.SharePoint.Client.ChangeType ChangeTypeEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.DateTime Time => TimeEx;
        public System.DateTime TimeEx { get; set; }

    }
}

