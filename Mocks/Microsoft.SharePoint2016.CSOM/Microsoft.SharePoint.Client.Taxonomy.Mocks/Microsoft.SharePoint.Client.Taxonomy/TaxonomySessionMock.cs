
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TaxonomySessionMock : TaxonomySession
    {


        public override System.String[] OfflineTermStoreNames => OfflineTermStoreNamesEx;
        public System.String[] OfflineTermStoreNamesEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermStoreCollection TermStores => TermStoresEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermStoreCollection TermStoresEx { get; set; }

    }
}

