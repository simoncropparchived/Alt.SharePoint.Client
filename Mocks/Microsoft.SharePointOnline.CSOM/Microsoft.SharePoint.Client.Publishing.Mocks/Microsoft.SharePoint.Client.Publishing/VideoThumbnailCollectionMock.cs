
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VideoThumbnailCollectionMock : VideoThumbnailCollection
    {


        public override Microsoft.SharePoint.Client.Publishing.VideoThumbnail GetByIndex(Microsoft.SharePoint.Client.Publishing.VideoThumbnailChoices @choice)
        {
            return GetByIndexEx;
        }
        public Microsoft.SharePoint.Client.Publishing.VideoThumbnail GetByIndexEx { get; set;}

    }
}

