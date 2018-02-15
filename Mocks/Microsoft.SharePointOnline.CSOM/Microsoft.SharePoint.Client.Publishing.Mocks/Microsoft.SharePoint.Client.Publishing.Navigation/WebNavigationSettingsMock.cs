
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class WebNavigationSettingsMock
    {


        public override System.Boolean AddNewPagesToNavigation => AddNewPagesToNavigationEx;
        public System.Boolean AddNewPagesToNavigationEx { get; set; }

        public override System.Boolean CreateFriendlyUrlsForNewPages => CreateFriendlyUrlsForNewPagesEx;
        public System.Boolean CreateFriendlyUrlsForNewPagesEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.StandardNavigationSettings CurrentNavigation => CurrentNavigationEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.StandardNavigationSettings CurrentNavigationEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Navigation.StandardNavigationSettings GlobalNavigation => GlobalNavigationEx;
        public Microsoft.SharePoint.Client.Publishing.Navigation.StandardNavigationSettings GlobalNavigationEx { get; set; }

    }
}

