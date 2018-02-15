
namespace Microsoft.SharePoint.Client.WebParts
{
    public class WebPartMock : WebPart
    {


        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Boolean IsClosed => IsClosedEx;
        public System.Boolean IsClosedEx { get; set; }

        public override Microsoft.SharePoint.Client.PropertyValues Properties => PropertiesEx;
        public Microsoft.SharePoint.Client.PropertyValues PropertiesEx { get; set; }

        public override System.String Subtitle => SubtitleEx;
        public System.String SubtitleEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TitleUrl => TitleUrlEx;
        public System.String TitleUrlEx { get; set; }

        public override System.Int32 ZoneIndex => ZoneIndexEx;
        public System.Int32 ZoneIndexEx { get; set; }

    }
}

