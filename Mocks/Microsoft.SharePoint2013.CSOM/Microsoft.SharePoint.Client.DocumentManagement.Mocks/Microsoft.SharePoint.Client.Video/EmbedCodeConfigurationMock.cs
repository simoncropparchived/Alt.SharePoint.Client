
namespace Microsoft.SharePoint.Client.Video
{
    public class EmbedCodeConfigurationMock : EmbedCodeConfiguration
    {


        public override System.Boolean AutoPlay => AutoPlayEx;
        public System.Boolean AutoPlayEx { get; set; }

        public override System.Boolean DisplayTitle => DisplayTitleEx;
        public System.Boolean DisplayTitleEx { get; set; }

        public override System.Boolean LinkToOwnerProfilePage => LinkToOwnerProfilePageEx;
        public System.Boolean LinkToOwnerProfilePageEx { get; set; }

        public override System.Boolean LinkToVideoHomePage => LinkToVideoHomePageEx;
        public System.Boolean LinkToVideoHomePageEx { get; set; }

        public override System.Boolean Loop => LoopEx;
        public System.Boolean LoopEx { get; set; }

        public override System.UInt32 PixelHeight => PixelHeightEx;
        public System.UInt32 PixelHeightEx { get; set; }

        public override System.UInt32 PixelWidth => PixelWidthEx;
        public System.UInt32 PixelWidthEx { get; set; }

        public override System.String PreviewImagePath => PreviewImagePathEx;
        public System.String PreviewImagePathEx { get; set; }

        public override System.UInt32 StartTime => StartTimeEx;
        public System.UInt32 StartTimeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

