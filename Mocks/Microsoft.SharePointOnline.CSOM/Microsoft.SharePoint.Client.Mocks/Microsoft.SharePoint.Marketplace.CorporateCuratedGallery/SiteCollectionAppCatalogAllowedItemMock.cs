
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Marketplace.CorporateCuratedGallery
{
    public class SiteCollectionAppCatalogAllowedItemMock : SiteCollectionAppCatalogAllowedItem
    {


        public override System.String AbsoluteUrl => AbsoluteUrlEx;
        public System.String AbsoluteUrlEx { get; set; }

        public override System.Guid SiteID => SiteIDEx;
        public System.Guid SiteIDEx { get; set; }

    }
}

