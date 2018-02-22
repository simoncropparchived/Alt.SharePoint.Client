
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialRestPostCreationDataMock : SocialRestPostCreationData
    {


        public override System.String ID => IDEx;
        public System.String IDEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPostCreationData creationData => creationDataEx;
        public Microsoft.SharePoint.Client.Social.SocialPostCreationData creationDataEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

