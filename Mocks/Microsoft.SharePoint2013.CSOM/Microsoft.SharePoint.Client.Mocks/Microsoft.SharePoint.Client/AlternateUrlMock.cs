
namespace Microsoft.SharePoint.Client
{
    public class AlternateUrlMock
    {


        public override System.String Uri => UriEx;
        public System.String UriEx { get; set; }

        public override Microsoft.SharePoint.Client.UrlZone UrlZone => UrlZoneEx;
        public Microsoft.SharePoint.Client.UrlZone UrlZoneEx { get; set; }

    }
}

