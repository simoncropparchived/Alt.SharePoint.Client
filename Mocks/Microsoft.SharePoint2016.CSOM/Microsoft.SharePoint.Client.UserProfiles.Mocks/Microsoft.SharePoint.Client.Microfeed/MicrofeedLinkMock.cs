
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedLinkMock : MicrofeedLink
    {


        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedLinkAction ClickAction => ClickActionEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedLinkAction ClickActionEx { get; set; }

        public override System.String ContentUri => ContentUriEx;
        public System.String ContentUriEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.UInt32 Height => HeightEx;
        public System.UInt32 HeightEx { get; set; }

        public override System.String Href => HrefEx;
        public System.String HrefEx { get; set; }

        public override System.UInt32 Length => LengthEx;
        public System.UInt32 LengthEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedLinkType LinkType => LinkTypeEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedLinkType LinkTypeEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.UInt32 PreviewHeight => PreviewHeightEx;
        public System.UInt32 PreviewHeightEx { get; set; }

        public override System.String PreviewPictureUrl => PreviewPictureUrlEx;
        public System.String PreviewPictureUrlEx { get; set; }

        public override System.UInt32 PreviewWidth => PreviewWidthEx;
        public System.UInt32 PreviewWidthEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode Status => StatusEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode StatusEx { get; set; }

        public override System.UInt32 Width => WidthEx;
        public System.UInt32 WidthEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

