
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class NavigationTermSetMock : NavigationTermSet
    {


        public override System.Boolean IsNavigationTermSet => IsNavigationTermSetEx;
        public System.Boolean IsNavigationTermSetEx { get; set; }

        public override System.Int32 Lcid => LcidEx;
        public System.Int32 LcidEx { get; set; }

        public override System.Boolean LoadedFromPersistedData => LoadedFromPersistedDataEx;
        public System.Boolean LoadedFromPersistedDataEx { get; set; }

        public override System.Guid TermGroupId => TermGroupIdEx;
        public System.Guid TermGroupIdEx { get; set; }

        public override System.Guid TermStoreId => TermStoreIdEx;
        public System.Guid TermStoreIdEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSet GetAsEditable(Microsoft.SharePoint.Client.Taxonomy.TaxonomySession @taxonomySession)
        {
            return GetAsEditableEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSet GetAsEditableEx { get; set;}

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSet GetWithNewView(Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSetView @newView)
        {
            return GetWithNewViewEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSet GetWithNewViewEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet GetTaxonomyTermSet()
        {
            return GetTaxonomyTermSetEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSet GetTaxonomyTermSetEx { get; set;}

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermCollection GetAllTerms()
        {
            return GetAllTermsEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermCollection GetAllTermsEx { get; set;}

        public override Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm FindTermForUrl(System.String @url)
        {
            return FindTermForUrlEx;
        }
        public Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTerm FindTermForUrlEx { get; set;}

    }
}

