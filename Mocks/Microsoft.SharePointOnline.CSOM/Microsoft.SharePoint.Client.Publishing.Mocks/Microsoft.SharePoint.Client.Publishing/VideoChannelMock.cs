
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VideoChannelMock : VideoChannel
    {


        public override System.Boolean CanAdministrateByCurrent => CanAdministrateByCurrentEx;
        public System.Boolean CanAdministrateByCurrentEx { get; set; }

        public override System.Boolean CanEditByCurrent => CanEditByCurrentEx;
        public System.Boolean CanEditByCurrentEx { get; set; }

        public override System.Boolean CanViewByCurrent => CanViewByCurrentEx;
        public System.Boolean CanViewByCurrentEx { get; set; }

        public override System.String ChannelPageUrl => ChannelPageUrlEx;
        public System.String ChannelPageUrlEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.ChannelPermission DownloadUrlVisibleMinPermission => DownloadUrlVisibleMinPermissionEx;
        public Microsoft.SharePoint.Client.Publishing.ChannelPermission DownloadUrlVisibleMinPermissionEx { get; set; }

        public override System.String FullUrl => FullUrlEx;
        public System.String FullUrlEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.Search Search => SearchEx;
        public Microsoft.SharePoint.Client.Publishing.Search SearchEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.Boolean ShareByEmailEnabled => ShareByEmailEnabledEx;
        public System.Boolean ShareByEmailEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.SpotlightVideoCollection SpotlightVideos => SpotlightVideosEx;
        public Microsoft.SharePoint.Client.Publishing.SpotlightVideoCollection SpotlightVideosEx { get; set; }

        public override System.String TileHtmlColor => TileHtmlColorEx;
        public System.String TileHtmlColorEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override Microsoft.SharePoint.Client.Publishing.VideoCollection Videos => VideosEx;
        public Microsoft.SharePoint.Client.Publishing.VideoCollection VideosEx { get; set; }

        public override System.Int32 YammerDefaultGroupId => YammerDefaultGroupIdEx;
        public System.Int32 YammerDefaultGroupIdEx { get; set; }

        public override System.Boolean YammerEnabled => YammerEnabledEx;
        public System.Boolean YammerEnabledEx { get; set; }

    }
}

