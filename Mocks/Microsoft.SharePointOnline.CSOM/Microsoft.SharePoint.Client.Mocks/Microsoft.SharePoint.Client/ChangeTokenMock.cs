
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ChangeTokenMock : ChangeToken
    {


        public override System.String StringValue => StringValueEx;
        public System.String StringValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

