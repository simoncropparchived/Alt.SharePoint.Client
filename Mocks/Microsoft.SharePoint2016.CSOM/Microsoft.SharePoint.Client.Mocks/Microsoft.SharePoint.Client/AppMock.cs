
namespace Microsoft.SharePoint.Client
{
    public class AppMock : App
    {


        public override System.String AssetId => AssetIdEx;
        public System.String AssetIdEx { get; set; }

        public override System.String ContentMarket => ContentMarketEx;
        public System.String ContentMarketEx { get; set; }

        public override System.String VersionString => VersionStringEx;
        public System.String VersionStringEx { get; set; }

    }
}

