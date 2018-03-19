
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing.Navigation
{
    public class NavigationTermProviderNameCollectionMock : NavigationTermProviderNameCollection
    {


        public override void Add(System.String @item)
        {
        }

        public override void Clear()
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(System.String @item)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

