
namespace Microsoft.SharePoint.Client
{
    public class AppInstanceMock : AppInstance
    {


        public override System.String AppPrincipalId => AppPrincipalIdEx;
        public System.String AppPrincipalIdEx { get; set; }

        public override System.String AppWebFullUrl => AppWebFullUrlEx;
        public System.String AppWebFullUrlEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean InError => InErrorEx;
        public System.Boolean InErrorEx { get; set; }

        public override System.String StartPage => StartPageEx;
        public System.String StartPageEx { get; set; }

        public override System.String RemoteAppUrl => RemoteAppUrlEx;
        public System.String RemoteAppUrlEx { get; set; }

        public override System.String SettingsPageUrl => SettingsPageUrlEx;
        public System.String SettingsPageUrlEx { get; set; }

        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override Microsoft.SharePoint.Client.AppInstanceStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.AppInstanceStatus StatusEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

