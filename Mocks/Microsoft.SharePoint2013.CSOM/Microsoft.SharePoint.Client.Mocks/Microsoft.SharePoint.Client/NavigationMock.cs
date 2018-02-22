
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class NavigationMock : Navigation
    {


        public override Microsoft.SharePoint.Client.NavigationNodeCollection QuickLaunch => QuickLaunchEx;
        public Microsoft.SharePoint.Client.NavigationNodeCollection QuickLaunchEx { get; set; }

        public override Microsoft.SharePoint.Client.NavigationNodeCollection TopNavigationBar => TopNavigationBarEx;
        public Microsoft.SharePoint.Client.NavigationNodeCollection TopNavigationBarEx { get; set; }

        public override System.Boolean UseShared => UseSharedEx;
        public System.Boolean UseSharedEx { get; set; }

        public override Microsoft.SharePoint.Client.NavigationNode GetNodeById(System.Int32 @id)
        {
            return GetNodeByIdEx;
        }
        public Microsoft.SharePoint.Client.NavigationNode GetNodeByIdEx { get; set;}

    }
}

