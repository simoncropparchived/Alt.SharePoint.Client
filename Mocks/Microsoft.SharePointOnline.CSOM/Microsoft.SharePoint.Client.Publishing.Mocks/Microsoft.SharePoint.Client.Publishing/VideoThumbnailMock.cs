
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VideoThumbnailMock : VideoThumbnail
    {


        public override Microsoft.SharePoint.Client.Publishing.VideoThumbnailChoices Choice => ChoiceEx;
        public Microsoft.SharePoint.Client.Publishing.VideoThumbnailChoices ChoiceEx { get; set; }

        public override System.Boolean IsSelected => IsSelectedEx;
        public System.Boolean IsSelectedEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

    }
}

