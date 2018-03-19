
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListItemCreationInformationMock : ListItemCreationInformation
    {


        public override System.String FolderUrl => FolderUrlEx;
        public System.String FolderUrlEx { get; set; }

        public override System.String LeafName => LeafNameEx;
        public System.String LeafNameEx { get; set; }

        public override Microsoft.SharePoint.Client.FileSystemObjectType UnderlyingObjectType => UnderlyingObjectTypeEx;
        public Microsoft.SharePoint.Client.FileSystemObjectType UnderlyingObjectTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

