
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VideoCollectionMock : VideoCollection
    {


        public override Microsoft.SharePoint.Client.Publishing.VideoItem GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Publishing.VideoItem GetByIdEx { get; set;}

    }
}

