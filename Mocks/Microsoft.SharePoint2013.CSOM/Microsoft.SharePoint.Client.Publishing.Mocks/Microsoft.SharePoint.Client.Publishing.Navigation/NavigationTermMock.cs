
// ReSharper disable IdentifierTypo
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

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm GetAsEditable(Microsoft.SharePoint.Client.Taxonomy.TaxonomySession @taxonomySession)
        {
            return GetAsEditableEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm GetAsEditableEx { get; set;}

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm GetWithNewView(Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSetView @newView)
        {
            return GetWithNewViewEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm GetWithNewViewEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedTargetUrl(System.String @browserQueryString, System.String[] @remainingUrlSegments)
        {
            return GetResolvedTargetUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedTargetUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedTargetUrlWithoutQuery()
        {
            return GetResolvedTargetUrlWithoutQueryEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedTargetUrlWithoutQueryEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedAssociatedFolderUrl()
        {
            return GetResolvedAssociatedFolderUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedAssociatedFolderUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetWebRelativeFriendlyUrl()
        {
            return GetWebRelativeFriendlyUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetWebRelativeFriendlyUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermCollection GetAllParentTerms()
        {
            return GetAllParentTermsEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermCollection GetAllParentTermsEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term GetTaxonomyTerm()
        {
            return GetTaxonomyTermEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term GetTaxonomyTermEx { get; set;}

        public override void Move(Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSetItem @newParent)
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

