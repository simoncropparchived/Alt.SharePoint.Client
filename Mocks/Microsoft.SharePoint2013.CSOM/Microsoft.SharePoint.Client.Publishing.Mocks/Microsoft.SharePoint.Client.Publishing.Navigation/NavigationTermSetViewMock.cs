
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class NavigationTermSetViewMock
    {


        public override System.Boolean ExcludeDeprecatedTerms => ExcludeDeprecatedTermsEx;
        public System.Boolean ExcludeDeprecatedTermsEx { get; set; }

        public override System.Boolean ExcludeTermsByPermissions => ExcludeTermsByPermissionsEx;
        public System.Boolean ExcludeTermsByPermissionsEx { get; set; }

        public override System.Boolean ExcludeTermsByProvider => ExcludeTermsByProviderEx;
        public System.Boolean ExcludeTermsByProviderEx { get; set; }

        public override System.String ServerRelativeSiteUrl => ServerRelativeSiteUrlEx;
        public System.String ServerRelativeSiteUrlEx { get; set; }

        public override System.String ServerRelativeWebUrl => ServerRelativeWebUrlEx;
        public System.String ServerRelativeWebUrlEx { get; set; }

        public override System.String SiteMapProviderName => SiteMapProviderNameEx;
        public System.String SiteMapProviderNameEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

        public override System.String WebTitle => WebTitleEx;
        public System.String WebTitleEx { get; set; }

    }
}

