
namespace Microsoft.SharePoint.Client
{
    public class AppTileMock : AppTile
    {


        public override System.Guid AppId => AppIdEx;
        public System.Guid AppIdEx { get; set; }

        public override System.String AppPrincipalId => AppPrincipalIdEx;
        public System.String AppPrincipalIdEx { get; set; }

        public override Microsoft.SharePoint.Administration.AppSource AppSource => AppSourceEx;
        public Microsoft.SharePoint.Administration.AppSource AppSourceEx { get; set; }

        public override Microsoft.SharePoint.Client.AppStatus AppStatus => AppStatusEx;
        public Microsoft.SharePoint.Client.AppStatus AppStatusEx { get; set; }

        public override Microsoft.SharePoint.Client.AppType AppType => AppTypeEx;
        public Microsoft.SharePoint.Client.AppType AppTypeEx { get; set; }

        public override System.String AssetId => AssetIdEx;
        public System.String AssetIdEx { get; set; }

        public override Microsoft.SharePoint.Client.ListTemplateType BaseTemplate => BaseTemplateEx;
        public Microsoft.SharePoint.Client.ListTemplateType BaseTemplateEx { get; set; }

        public override System.Int32 ChildCount => ChildCountEx;
        public System.Int32 ChildCountEx { get; set; }

        public override System.String ContentMarket => ContentMarketEx;
        public System.String ContentMarketEx { get; set; }

        public override System.String CustomSettingsUrl => CustomSettingsUrlEx;
        public System.String CustomSettingsUrlEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean IsCorporateCatalogSite => IsCorporateCatalogSiteEx;
        public System.Boolean IsCorporateCatalogSiteEx { get; set; }

        public override System.String LastModified => LastModifiedEx;
        public System.String LastModifiedEx { get; set; }

        public override System.DateTime LastModifiedDate => LastModifiedDateEx;
        public System.DateTime LastModifiedDateEx { get; set; }

        public override System.Guid ProductId => ProductIdEx;
        public System.Guid ProductIdEx { get; set; }

        public override System.String Target => TargetEx;
        public System.String TargetEx { get; set; }

        public override System.String Thumbnail => ThumbnailEx;
        public System.String ThumbnailEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Version => VersionEx;
        public System.String VersionEx { get; set; }

    }
}

