
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VideoChannelCollectionMock : VideoChannelCollection
    {


        public override Microsoft.SharePoint.Client.Publishing.VideoChannel GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.Publishing.VideoChannel GetByIdEx { get; set;}

    }
}

