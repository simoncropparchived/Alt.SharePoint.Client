
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ContentTypeIdMock : ContentTypeId
    {


        public override System.String StringValue => StringValueEx;
        public System.String StringValueEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override System.String ToString()
        {
            return ToStringEx;
        }
        public System.String ToStringEx { get; set;}

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

