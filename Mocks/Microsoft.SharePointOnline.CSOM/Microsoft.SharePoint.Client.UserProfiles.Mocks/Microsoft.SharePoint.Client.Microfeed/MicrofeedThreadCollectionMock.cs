
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedThreadCollectionMock : MicrofeedThreadCollection
    {


        public override System.Int32 CurrentUserUnreadMentionCount => CurrentUserUnreadMentionCountEx;
        public System.Int32 CurrentUserUnreadMentionCountEx { get; set; }

        public override System.DateTime NewestProcessed => NewestProcessedEx;
        public System.DateTime NewestProcessedEx { get; set; }

        public override System.DateTime OldestProcessed => OldestProcessedEx;
        public System.DateTime OldestProcessedEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

