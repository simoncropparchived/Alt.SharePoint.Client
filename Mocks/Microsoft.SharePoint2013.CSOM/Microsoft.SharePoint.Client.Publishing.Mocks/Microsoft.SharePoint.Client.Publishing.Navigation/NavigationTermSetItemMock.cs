
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class NavigationTermSetItemMock : NavigationTermSetItem
    {


        public override Microsoft.SharePoint.Client.Publishing.CustomizableString CatalogTargetUrlForChildTerms => CatalogTargetUrlForChildTermsEx;
        public Microsoft.SharePoint.Client.Publishing.CustomizableString CatalogTargetUrlForChildTermsEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsReadOnly => IsReadOnlyEx;
        public System.Boolean IsReadOnlyEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationLinkType LinkType => LinkTypeEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationLinkType LinkTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.CustomizableString TargetUrlForChildTerms => TargetUrlForChildTermsEx;
        public Microsoft.SharePoint.Client.Publishing.CustomizableString TargetUrlForChildTermsEx { get; set; }

        public override System.String TaxonomyName => TaxonomyNameEx;
        public System.String TaxonomyNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermCollection Terms => TermsEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermCollection TermsEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.CustomizableString Title => TitleEx;
        public Microsoft.SharePoint.Client.Publishing.CustomizableString TitleEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSetView View => ViewEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSetView ViewEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedDisplayUrl(System.String @browserQueryString)
        {
            return GetResolvedDisplayUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetResolvedDisplayUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermStore GetTaxonomyTermStore()
        {
            return GetTaxonomyTermStoreEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermStore GetTaxonomyTermStoreEx { get; set;}

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm CreateTerm(System.String @termName, Microsoft.SharePoint.Client.Publishing.Navigation.NavigationLinkType @linkType, System.Guid @termId)
        {
            return CreateTermEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm CreateTermEx { get; set;}

    }
}

