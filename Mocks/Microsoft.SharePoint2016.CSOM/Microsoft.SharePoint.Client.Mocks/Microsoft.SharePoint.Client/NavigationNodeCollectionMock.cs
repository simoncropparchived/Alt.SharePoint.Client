
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class NavigationNodeCollectionMock : NavigationNodeCollection
    {


        public override Microsoft.SharePoint.Client.NavigationNode Add(Microsoft.SharePoint.Client.NavigationNodeCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.NavigationNode AddEx { get; set;}

    }
}

