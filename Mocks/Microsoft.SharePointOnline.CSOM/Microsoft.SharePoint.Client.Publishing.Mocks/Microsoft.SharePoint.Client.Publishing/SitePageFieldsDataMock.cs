
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SitePageFieldsDataMock : SitePageFieldsData
    {


        public override System.String BannerImageUrl => BannerImageUrlEx;
        public System.String BannerImageUrlEx { get; set; }

        public override System.String CanvasContent1 => CanvasContent1Ex;
        public System.String CanvasContent1Ex { get; set; }

        public override System.String CanvasJson1 => CanvasJson1Ex;
        public System.String CanvasJson1Ex { get; set; }

        public override System.String LayoutWebpartsContent => LayoutWebpartsContentEx;
        public System.String LayoutWebpartsContentEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

