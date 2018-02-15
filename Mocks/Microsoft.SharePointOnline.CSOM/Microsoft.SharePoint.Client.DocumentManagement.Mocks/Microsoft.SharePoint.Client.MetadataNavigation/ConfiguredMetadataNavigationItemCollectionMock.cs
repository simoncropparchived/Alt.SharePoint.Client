
namespace Microsoft.SharePoint.Client.MetadataNavigation
{
    public class ConfiguredMetadataNavigationItemCollectionMock : ConfiguredMetadataNavigationItemCollection
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

