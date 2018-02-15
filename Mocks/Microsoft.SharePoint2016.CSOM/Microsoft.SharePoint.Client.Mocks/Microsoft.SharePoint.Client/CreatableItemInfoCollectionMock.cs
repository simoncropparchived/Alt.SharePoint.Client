
namespace Microsoft.SharePoint.Client
{
    public class CreatableItemInfoCollectionMock : CreatableItemInfoCollection
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

