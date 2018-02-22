
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FolderCollectionAddParametersMock : FolderCollectionAddParameters
    {


        public override System.Boolean Overwrite => OverwriteEx;
        public System.Boolean OverwriteEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

