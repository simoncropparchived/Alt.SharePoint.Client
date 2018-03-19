
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class CopyMigrationInfoMock : CopyMigrationInfo
    {


        public override System.Byte[] EncryptionKey => EncryptionKeyEx;
        public System.Byte[] EncryptionKeyEx { get; set; }

        public override System.Guid JobId => JobIdEx;
        public System.Guid JobIdEx { get; set; }

        public override System.String JobQueueUri => JobQueueUriEx;
        public System.String JobQueueUriEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

