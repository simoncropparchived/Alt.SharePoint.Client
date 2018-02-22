
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ListCollectionMock : ListCollection
    {


        public override Microsoft.SharePoint.Client.List GetByTitle(System.String @title)
        {
            return GetByTitleEx;
        }
        public Microsoft.SharePoint.Client.List GetByTitleEx { get; set;}

        public override Microsoft.SharePoint.Client.List GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.List GetByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.List Add(Microsoft.SharePoint.Client.ListCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Client.List AddEx { get; set;}

        public override Microsoft.SharePoint.Client.List EnsureSitePagesLibrary()
        {
            return EnsureSitePagesLibraryEx;
        }
        public Microsoft.SharePoint.Client.List EnsureSitePagesLibraryEx { get; set;}

        public override Microsoft.SharePoint.Client.List EnsureClientRenderedSitePagesLibrary()
        {
            return EnsureClientRenderedSitePagesLibraryEx;
        }
        public Microsoft.SharePoint.Client.List EnsureClientRenderedSitePagesLibraryEx { get; set;}

        public override Microsoft.SharePoint.Client.List EnsureSiteAssetsLibrary()
        {
            return EnsureSiteAssetsLibraryEx;
        }
        public Microsoft.SharePoint.Client.List EnsureSiteAssetsLibraryEx { get; set;}

    }
}

