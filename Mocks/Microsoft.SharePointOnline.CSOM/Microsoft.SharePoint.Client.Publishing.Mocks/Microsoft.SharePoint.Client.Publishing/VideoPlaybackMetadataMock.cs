
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VideoPlaybackMetadataMock : VideoPlaybackMetadata
    {


        public override System.String HLSUrl => HLSUrlEx;
        public System.String HLSUrlEx { get; set; }

        public override System.String SdnPlaybackMetadata => SdnPlaybackMetadataEx;
        public System.String SdnPlaybackMetadataEx { get; set; }

        public override System.String StreamingUrl => StreamingUrlEx;
        public System.String StreamingUrlEx { get; set; }

        public override System.String Token => TokenEx;
        public System.String TokenEx { get; set; }

    }
}

