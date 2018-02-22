
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class LanguageMock : Language
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String LanguageTag => LanguageTagEx;
        public System.String LanguageTagEx { get; set; }

        public override System.Int32 Lcid => LcidEx;
        public System.Int32 LcidEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

