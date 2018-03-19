
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialPostDefinitionDataMock : SocialPostDefinitionData
    {


        public override Microsoft.SharePoint.Client.Social.SocialPostDefinitionDataItem[] Items => ItemsEx;
        public Microsoft.SharePoint.Client.Social.SocialPostDefinitionDataItem[] ItemsEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

