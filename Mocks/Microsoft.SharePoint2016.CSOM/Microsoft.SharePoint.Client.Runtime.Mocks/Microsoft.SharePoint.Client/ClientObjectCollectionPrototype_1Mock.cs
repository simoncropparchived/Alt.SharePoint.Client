
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectCollectionPrototypeMock<ItemType> : ClientObjectCollectionPrototype<ItemType>
    {


        public override Microsoft.SharePoint.Client.ClientObjectPrototype<ItemType> RetrieveItems()
        {
            return RetrieveItemsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectPrototype<ItemType> RetrieveItemsEx { get; set;}

    }
}

