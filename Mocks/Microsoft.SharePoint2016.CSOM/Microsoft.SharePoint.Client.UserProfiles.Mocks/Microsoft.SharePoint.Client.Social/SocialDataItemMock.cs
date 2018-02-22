
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialDataItemMock : SocialDataItem
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialDataItemType ItemType => ItemTypeEx;
        public Microsoft.SharePoint.Client.Social.SocialDataItemType ItemTypeEx { get; set; }

        public override System.Guid TagGuid => TagGuidEx;
        public System.Guid TagGuidEx { get; set; }

        public override System.String Text => TextEx;
        public System.String TextEx { get; set; }

        public override System.String Uri => UriEx;
        public System.String UriEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

