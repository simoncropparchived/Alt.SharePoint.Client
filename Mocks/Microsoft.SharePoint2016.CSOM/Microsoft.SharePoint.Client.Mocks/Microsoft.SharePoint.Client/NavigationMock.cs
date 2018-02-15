
namespace Microsoft.SharePoint.Client
{
    public class NavigationMock
    {


        public override Microsoft.SharePoint.Client.NavigationNodeCollection QuickLaunch => QuickLaunchEx;
        public Microsoft.SharePoint.Client.NavigationNodeCollection QuickLaunchEx { get; set; }

        public override Microsoft.SharePoint.Client.NavigationNodeCollection TopNavigationBar => TopNavigationBarEx;
        public Microsoft.SharePoint.Client.NavigationNodeCollection TopNavigationBarEx { get; set; }

        public override System.Boolean UseShared => UseSharedEx;
        public System.Boolean UseSharedEx { get; set; }

    }
}

