
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class DeletedSitePropertiesMock
    {


        public override System.Int32 DaysRemaining => DaysRemainingEx;
        public System.Int32 DaysRemainingEx { get; set; }

        public override System.DateTime DeletionTime => DeletionTimeEx;
        public System.DateTime DeletionTimeEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.String Status => StatusEx;
        public System.String StatusEx { get; set; }

        public override System.Int64 StorageMaximumLevel => StorageMaximumLevelEx;
        public System.Int64 StorageMaximumLevelEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.Double UserCodeMaximumLevel => UserCodeMaximumLevelEx;
        public System.Double UserCodeMaximumLevelEx { get; set; }

    }
}

