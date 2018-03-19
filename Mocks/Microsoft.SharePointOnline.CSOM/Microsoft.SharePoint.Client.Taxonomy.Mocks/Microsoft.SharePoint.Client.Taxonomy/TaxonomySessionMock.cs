
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TaxonomySessionMock : TaxonomySession
    {


        public override System.String[] OfflineTermStoreNames => OfflineTermStoreNamesEx;
        public System.String[] OfflineTermStoreNamesEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermStoreCollection TermStores => TermStoresEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermStoreCollection TermStoresEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTerms(Microsoft.SharePoint.Client.Taxonomy.LabelMatchInformation @labelMatchInformation)
        {
            return GetTermsEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsEx { get; set;}

        public override void UpdateCache()
        {
        }

        public override Microsoft.SharePoint.Client.Taxonomy.Term GetTerm(System.Guid @termId)
        {
            return GetTermEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term GetTermEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsById(System.Guid[] @termIds)
        {
            return GetTermsByIdEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsInDefaultLanguage(System.String @termLabel, System.Boolean @defaultLabelOnly, Microsoft.SharePoint.Client.Taxonomy.StringMatchOption @stringMatchOption, System.Int32 @resultCollectionSize, System.Boolean @trimUnavailable, System.Boolean @trimDeprecated)
        {
            return GetTermsInDefaultLanguageEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsInDefaultLanguageEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsInWorkingLocale(System.String @termLabel, System.Boolean @defaultLabelOnly, Microsoft.SharePoint.Client.Taxonomy.StringMatchOption @stringMatchOption, System.Int32 @resultCollectionSize, System.Boolean @trimUnavailable, System.Boolean @trimDeprecated)
        {
            return GetTermsInWorkingLocaleEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsInWorkingLocaleEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsWithCustomProperty(Microsoft.SharePoint.Client.Taxonomy.CustomPropertyMatchInformation @customPropertyMatchInformation)
        {
            return GetTermsWithCustomPropertyEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsWithCustomPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByName(System.String @termSetName, System.Int32 @lcid)
        {
            return GetTermSetsByNameEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByNameEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByTermLabel(System.String[] @requiredTermLabels, System.Int32 @lcid)
        {
            return GetTermSetsByTermLabelEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByTermLabelEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermStore GetDefaultKeywordsTermStore()
        {
            return GetDefaultKeywordsTermStoreEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermStore GetDefaultKeywordsTermStoreEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermStore GetDefaultSiteCollectionTermStore()
        {
            return GetDefaultSiteCollectionTermStoreEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermStore GetDefaultSiteCollectionTermStoreEx { get; set;}

    }
}

