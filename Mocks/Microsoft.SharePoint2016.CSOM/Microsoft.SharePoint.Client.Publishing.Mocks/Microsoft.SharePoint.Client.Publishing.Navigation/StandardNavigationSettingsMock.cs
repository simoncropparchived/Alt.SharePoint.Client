
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class StandardNavigationSettingsMock
    {


        public override Microsoft.SharePoint.Client.Publishing.Navigation.StandardNavigationSource Source => SourceEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.StandardNavigationSource SourceEx { get; set; }

        public override System.Guid TermSetId => TermSetIdEx;
        public System.Guid TermSetIdEx { get; set; }

        public override System.Guid TermStoreId => TermStoreIdEx;
        public System.Guid TermStoreIdEx { get; set; }

    }
}

