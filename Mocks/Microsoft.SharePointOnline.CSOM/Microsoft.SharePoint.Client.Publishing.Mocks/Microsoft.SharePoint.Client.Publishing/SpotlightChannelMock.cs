
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SpotlightChannelMock
    {


        public override Microsoft.SharePoint.Client.Publishing.VideoChannel Channel => ChannelEx;
        public Microsoft.SharePoint.Client.Publishing.VideoChannel ChannelEx { get; set; }

        public override System.Guid ChannelId => ChannelIdEx;
        public System.Guid ChannelIdEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.String TileHtmlColor => TileHtmlColorEx;
        public System.String TileHtmlColorEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String VideoLibraryServerRelativeUrl => VideoLibraryServerRelativeUrlEx;
        public System.String VideoLibraryServerRelativeUrlEx { get; set; }

    }
}

