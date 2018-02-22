
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VideoItemMock : VideoItem
    {


        public override Microsoft.SharePoint.Client.User Author => AuthorEx;
        public Microsoft.SharePoint.Client.User AuthorEx { get; set; }

        public override System.Guid ChannelID => ChannelIDEx;
        public System.Guid ChannelIDEx { get; set; }

        public override System.DateTime CreatedDate => CreatedDateEx;
        public System.DateTime CreatedDateEx { get; set; }

        public override System.String DefaultEmbedCode => DefaultEmbedCodeEx;
        public System.String DefaultEmbedCodeEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String DisplayFormUrl => DisplayFormUrlEx;
        public System.String DisplayFormUrlEx { get; set; }

        public override System.String FileName => FileNameEx;
        public System.String FileNameEx { get; set; }

        public override Microsoft.SharePoint.Client.User Owner => OwnerEx;
        public Microsoft.SharePoint.Client.User OwnerEx { get; set; }

        public override System.String OwnerName => OwnerNameEx;
        public System.String OwnerNameEx { get; set; }

        public override Microsoft.SharePoint.Client.UserCollection PeopleInMedia => PeopleInMediaEx;
        public Microsoft.SharePoint.Client.UserCollection PeopleInMediaEx { get; set; }

        public override System.String PlayerPageUrl => PlayerPageUrlEx;
        public System.String PlayerPageUrlEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.VideoThumbnailChoices ThumbnailSelection => ThumbnailSelectionEx;
        public Microsoft.SharePoint.Client.Publishing.VideoThumbnailChoices ThumbnailSelectionEx { get; set; }

        public override System.String ThumbnailUrl => ThumbnailUrlEx;
        public System.String ThumbnailUrlEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Guid ID => IDEx;
        public System.Guid IDEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String VideoDownloadUrl => VideoDownloadUrlEx;
        public System.String VideoDownloadUrlEx { get; set; }

        public override System.Int32 VideoDurationInSeconds => VideoDurationInSecondsEx;
        public System.Int32 VideoDurationInSecondsEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.VideoProcessingStatus VideoProcessingStatus => VideoProcessingStatusEx;
        public Microsoft.SharePoint.Client.Publishing.VideoProcessingStatus VideoProcessingStatusEx { get; set; }

        public override System.Int32 ViewCount => ViewCountEx;
        public System.Int32 ViewCountEx { get; set; }

        public override System.String YammerObjectUrl => YammerObjectUrlEx;
        public System.String YammerObjectUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetPlaybackUrl(Microsoft.SharePoint.Client.Publishing.VideoStreamingFormat @videoFormat)
        {
            return GetPlaybackUrlEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetPlaybackUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetStreamingKeyAccessToken()
        {
            return GetStreamingKeyAccessTokenEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetStreamingKeyAccessTokenEx { get; set;}

        public override Microsoft.SharePoint.Client.Publishing.VideoPlaybackMetadata GetPlaybackMetadata(System.String @sdnConfiguration)
        {
            return GetPlaybackMetadataEx;
        }
        public Microsoft.SharePoint.Client.Publishing.VideoPlaybackMetadata GetPlaybackMetadataEx { get; set;}

        public override void Update()
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

