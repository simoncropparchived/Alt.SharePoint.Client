
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Utilities
{
    public class EmailPropertiesMock : EmailProperties
    {


        public override System.Collections.Generic.IDictionary<System.String,System.String> AdditionalHeaders => AdditionalHeadersEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> AdditionalHeadersEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> BCC => BCCEx;
        public System.Collections.Generic.IEnumerable<System.String> BCCEx { get; set; }

        public override System.String Body => BodyEx;
        public System.String BodyEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> CC => CCEx;
        public System.Collections.Generic.IEnumerable<System.String> CCEx { get; set; }

        public override System.String From => FromEx;
        public System.String FromEx { get; set; }

        public override System.String Subject => SubjectEx;
        public System.String SubjectEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> To => ToEx;
        public System.Collections.Generic.IEnumerable<System.String> ToEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

