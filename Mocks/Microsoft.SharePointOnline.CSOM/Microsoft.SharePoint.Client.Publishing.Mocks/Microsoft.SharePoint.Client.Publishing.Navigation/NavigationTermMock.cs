
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class NavigationTermMock : NavigationTerm
    {


        public override System.String AssociatedFolderUrl => AssociatedFolderUrlEx;
        public System.String AssociatedFolderUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.CustomizableString CatalogTargetUrl => CatalogTargetUrlEx;
        public Microsoft.SharePoint.Client.Publishing.CustomizableString CatalogTargetUrlEx { get; set; }

        public override System.String CategoryImageUrl => CategoryImageUrlEx;
        public System.String CategoryImageUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermProviderNameCollection ExcludedProviders => ExcludedProvidersEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermProviderNameCollection ExcludedProvidersEx { get; set; }

        public override System.Boolean ExcludeFromCurrentNavigation => ExcludeFromCurrentNavigationEx;
        public System.Boolean ExcludeFromCurrentNavigationEx { get; set; }

        public override System.Boolean ExcludeFromGlobalNavigation => ExcludeFromGlobalNavigationEx;
        public System.Boolean ExcludeFromGlobalNavigationEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.CustomizableString FriendlyUrlSegment => FriendlyUrlSegmentEx;
        public Microsoft.SharePoint.Client.Publishing.CustomizableString FriendlyUrlSegmentEx { get; set; }

        public override System.String HoverText => HoverTextEx;
        public System.String HoverTextEx { get; set; }

        public override System.Boolean IsDeprecated => IsDeprecatedEx;
        public System.Boolean IsDeprecatedEx { get; set; }

        public override System.Boolean IsPinned => IsPinnedEx;
        public System.Boolean IsPinnedEx { get; set; }

        public override System.Boolean IsPinnedRoot => IsPinnedRootEx;
        public System.Boolean IsPinnedRootEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm Parent => ParentEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm ParentEx { get; set; }

        public override System.String SimpleLinkUrl => SimpleLinkUrlEx;
        public System.String SimpleLinkUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.CustomizableString TargetUrl => TargetUrlEx;
        public Microsoft.SharePoint.Client.Publishing.CustomizableString TargetUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSet TermSet => TermSetEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSet TermSetEx { get; set; }

    }
}

