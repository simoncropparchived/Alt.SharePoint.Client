
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectCollectionMock : ClientObjectCollection
    {


        public override System.Boolean AreItemsAvailable => AreItemsAvailableEx;
        public System.Boolean AreItemsAvailableEx { get; set; }

        public override System.Int32 Count => CountEx;
        public System.Int32 CountEx { get; set; }

    }
}

