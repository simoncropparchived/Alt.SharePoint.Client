
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class MessagesFieldsDataMock : MessagesFieldsData
    {


        public override System.String bearToken => bearTokenEx;
        public System.String bearTokenEx { get; set; }

        public override System.String environment => environmentEx;
        public System.String environmentEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

