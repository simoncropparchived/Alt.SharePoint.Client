
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FileSaveBinaryInformationMock : FileSaveBinaryInformation
    {


        public override System.Boolean CheckRequiredFields => CheckRequiredFieldsEx;
        public System.Boolean CheckRequiredFieldsEx { get; set; }

        public override System.Byte[] Content => ContentEx;
        public System.Byte[] ContentEx { get; set; }

        public override System.IO.Stream ContentStream => ContentStreamEx;
        public System.IO.Stream ContentStreamEx { get; set; }

        public override System.String ETag => ETagEx;
        public System.String ETagEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.IDictionary<System.String,System.Object> FieldValuesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

