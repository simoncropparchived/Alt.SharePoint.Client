
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SubtitleCollectionMock : SubtitleCollection
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetSubtitleFile(System.String @name)
        {
            return GetSubtitleFileEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> GetSubtitleFileEx { get; set;}

    }
}

