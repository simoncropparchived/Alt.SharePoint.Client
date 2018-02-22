
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class WebCreationInformationMock : WebCreationInformation
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Int32 Language => LanguageEx;
        public System.Int32 LanguageEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.Boolean UseSamePermissionsAsParentSite => UseSamePermissionsAsParentSiteEx;
        public System.Boolean UseSamePermissionsAsParentSiteEx { get; set; }

        public override System.String WebTemplate => WebTemplateEx;
        public System.String WebTemplateEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

