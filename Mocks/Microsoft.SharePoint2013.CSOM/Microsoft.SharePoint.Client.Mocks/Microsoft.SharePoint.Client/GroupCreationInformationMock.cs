
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class GroupCreationInformationMock : GroupCreationInformation
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

