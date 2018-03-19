
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TaxonomyFieldValueMock : TaxonomyFieldValue
    {


        public override System.String Label => LabelEx;
        public System.String LabelEx { get; set; }

        public override System.String TermGuid => TermGuidEx;
        public System.String TermGuidEx { get; set; }

        public override System.Int32 WssId => WssIdEx;
        public System.Int32 WssIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

