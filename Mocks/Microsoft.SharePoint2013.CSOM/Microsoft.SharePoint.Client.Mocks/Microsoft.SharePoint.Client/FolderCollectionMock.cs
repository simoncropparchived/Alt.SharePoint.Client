
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FolderCollectionMock : FolderCollection
    {


        public override Microsoft.SharePoint.Client.Folder GetByUrl(System.String @url)
        {
            return GetByUrlEx;
        }
        public Microsoft.SharePoint.Client.Folder GetByUrlEx { get; set;}

        public override Microsoft.SharePoint.Client.Folder Add(System.String @url)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Folder AddEx { get; set;}

    }
}

