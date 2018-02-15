
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SpotlightVideoMock : SpotlightVideo
    {


        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.VideoItem Video => VideoEx;
        public Microsoft.SharePoint.Client.Publishing.VideoItem VideoEx { get; set; }

    }
}

