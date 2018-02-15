
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialDataOverlayMock
    {


        public override System.Int32[] ActorIndexes => ActorIndexesEx;
        public System.Int32[] ActorIndexesEx { get; set; }

        public override System.Int32 Index => IndexEx;
        public System.Int32 IndexEx { get; set; }

        public override System.Int32 Length => LengthEx;
        public System.Int32 LengthEx { get; set; }

        public override System.String LinkUri => LinkUriEx;
        public System.String LinkUriEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialDataOverlayType OverlayType => OverlayTypeEx;
        public Microsoft.SharePoint.Client.Social.SocialDataOverlayType OverlayTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

