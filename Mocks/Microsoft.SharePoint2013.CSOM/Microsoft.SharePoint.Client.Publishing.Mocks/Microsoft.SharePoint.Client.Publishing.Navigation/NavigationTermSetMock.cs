
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class NavigationTermSetMock
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

    }
}

