
namespace Microsoft.SharePoint.Client
{
    public class ProvisionedMigrationContainersInfoMock : ProvisionedMigrationContainersInfo
    {


        public override System.String DataContainerUri => DataContainerUriEx;
        public System.String DataContainerUriEx { get; set; }

        public override System.Byte[] EncryptionKey => EncryptionKeyEx;
        public System.Byte[] EncryptionKeyEx { get; set; }

        public override System.String MetadataContainerUri => MetadataContainerUriEx;
        public System.String MetadataContainerUriEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

