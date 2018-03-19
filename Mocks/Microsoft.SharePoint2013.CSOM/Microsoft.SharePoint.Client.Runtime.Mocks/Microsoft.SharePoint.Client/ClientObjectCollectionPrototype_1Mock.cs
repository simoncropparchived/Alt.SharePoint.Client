
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectCollectionPrototypeMock<T> : ClientObjectCollectionPrototype<T>
    {


        public override Microsoft.SharePoint.Client.ClientObjectPrototype<Microsoft.SharePoint.Client.ClientObjectCollectionPrototype.ItemType> RetrieveItems()
        {
            return RetrieveItemsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectPrototype<Microsoft.SharePoint.Client.ClientObjectCollectionPrototype.ItemType> RetrieveItemsEx { get; set;}

    }
}

