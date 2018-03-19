
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Marketplace.CorporateCuratedGallery
{
    public class SiteCollectionAppCatalogAllowedCollectionMock : SiteCollectionAppCatalogAllowedCollection
    {


        public override Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionAppCatalogAllowedItem Add(System.String @absolutePath)
        {
            return AddEx;
        }
        public Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionAppCatalogAllowedItem AddEx { get; set;}

        public override Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionAppCatalogAllowedItem GetByAbsoluteUrl(System.String @absolutePath)
        {
            return GetByAbsoluteUrlEx;
        }
        public Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionAppCatalogAllowedItem GetByAbsoluteUrlEx { get; set;}

        public override void RemoveById(System.Guid @siteId)
        {
        }

        public override void Remove(System.String @absolutePath)
        {
        }

    }
}

