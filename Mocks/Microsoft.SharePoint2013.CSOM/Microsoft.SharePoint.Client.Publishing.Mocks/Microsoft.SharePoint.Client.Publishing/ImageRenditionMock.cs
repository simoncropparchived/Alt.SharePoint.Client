
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class ImageRenditionMock : ImageRendition
    {


        public override System.Int32 Height => HeightEx;
        public System.Int32 HeightEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 Version => VersionEx;
        public System.Int32 VersionEx { get; set; }

        public override System.Int32 Width => WidthEx;
        public System.Int32 WidthEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

