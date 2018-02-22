
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

        public override Microsoft.SharePoint.Client.Folder GetByPath(Microsoft.SharePoint.Client.ResourcePath @path)
        {
            return GetByPathEx;
        }
        public Microsoft.SharePoint.Client.Folder GetByPathEx { get; set;}

        public override Microsoft.SharePoint.Client.Folder Add(System.String @url)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.Folder AddEx { get; set;}

        public override Microsoft.SharePoint.Client.Folder AddUsingPath(Microsoft.SharePoint.Client.ResourcePath @path, Microsoft.SharePoint.Client.FolderCollectionAddParameters @parameters)
        {
            return AddUsingPathEx;
        }
        public Microsoft.SharePoint.Client.Folder AddUsingPathEx { get; set;}

        public override Microsoft.SharePoint.Client.Folder AddWithOverwrite(System.String @url, System.Boolean @overwrite)
        {
            return AddWithOverwriteEx;
        }
        public Microsoft.SharePoint.Client.Folder AddWithOverwriteEx { get; set;}

    }
}

