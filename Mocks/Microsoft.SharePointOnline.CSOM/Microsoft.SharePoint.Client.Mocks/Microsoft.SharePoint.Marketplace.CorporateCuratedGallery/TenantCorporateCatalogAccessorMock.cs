
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Marketplace.CorporateCuratedGallery
{
    public class TenantCorporateCatalogAccessorMock : TenantCorporateCatalogAccessor
    {


        public override Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionAppCatalogAllowedCollection SiteCollectionAppCatalogsSites => SiteCollectionAppCatalogsSitesEx;
        public Microsoft.SharePoint.Marketplace.CorporateCuratedGallery.SiteCollectionAppCatalogAllowedCollection SiteCollectionAppCatalogsSitesEx { get; set; }

    }
}

