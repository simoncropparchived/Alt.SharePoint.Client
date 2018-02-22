
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class PublishingPageMock : PublishingPage
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.String> AddFriendlyUrl(System.String @friendlyUrlSegment, Microsoft.SharePoint.Client.Publishing.Navigation.NavigationTermSetItem @editableParent, System.Boolean @doAddToNavigation)
        {
            return AddFriendlyUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> AddFriendlyUrlEx { get; set;}

    }
}

