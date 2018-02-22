
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListDataSourceMock : ListDataSource
    {


        public override System.Collections.Generic.IDictionary<System.String,System.String> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> PropertiesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

