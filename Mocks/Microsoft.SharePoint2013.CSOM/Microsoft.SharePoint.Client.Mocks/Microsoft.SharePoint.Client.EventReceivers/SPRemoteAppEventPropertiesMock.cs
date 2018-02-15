
namespace Microsoft.SharePoint.Client.EventReceivers
{
    public class SPRemoteAppEventPropertiesMock
    {


        public override System.Uri HostWebFullUrl => HostWebFullUrlEx;
        public System.Uri HostWebFullUrlEx { get; set; }

        public override System.Uri AppWebFullUrl => AppWebFullUrlEx;
        public System.Uri AppWebFullUrlEx { get; set; }

        public override System.Version Version => VersionEx;
        public System.Version VersionEx { get; set; }

        public override System.Version PreviousVersion => PreviousVersionEx;
        public System.Version PreviousVersionEx { get; set; }

        public override System.Guid ProductId => ProductIdEx;
        public System.Guid ProductIdEx { get; set; }

        public override System.String AssetId => AssetIdEx;
        public System.String AssetIdEx { get; set; }

        public override System.String ContentMarket => ContentMarketEx;
        public System.String ContentMarketEx { get; set; }

    }
}

