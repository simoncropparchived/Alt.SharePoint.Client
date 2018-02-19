
namespace Microsoft.SharePoint.Client.WebParts
{
    public class TileDataMock : TileData
    {


        public override System.Collections.Generic.IEnumerable<System.String> BackgroundCollageImageLocations => BackgroundCollageImageLocationsEx;
        public System.Collections.Generic.IEnumerable<System.String> BackgroundCollageImageLocationsEx { get; set; }

        public override System.String BackgroundImageLocation => BackgroundImageLocationEx;
        public System.String BackgroundImageLocationEx { get; set; }

        public override System.Boolean BackgroundImageRendersAsIcon => BackgroundImageRendersAsIconEx;
        public System.Boolean BackgroundImageRendersAsIconEx { get; set; }

        public override System.String BodyText => BodyTextEx;
        public System.String BodyTextEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean HoverDisabled => HoverDisabledEx;
        public System.Boolean HoverDisabledEx { get; set; }

        public override System.Int32 ID => IDEx;
        public System.Int32 IDEx { get; set; }

        public override System.Boolean IsWide => IsWideEx;
        public System.Boolean IsWideEx { get; set; }

        public override System.String LinkLocation => LinkLocationEx;
        public System.String LinkLocationEx { get; set; }

        public override System.Int32 TileOrder => TileOrderEx;
        public System.Int32 TileOrderEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Boolean TransparentOverlay => TransparentOverlayEx;
        public System.Boolean TransparentOverlayEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

