
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantSiteDesignMock : TenantSiteDesign
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsDefault => IsDefaultEx;
        public System.Boolean IsDefaultEx { get; set; }

        public override System.String PreviewImageAltText => PreviewImageAltTextEx;
        public System.String PreviewImageAltTextEx { get; set; }

        public override System.String PreviewImageUrl => PreviewImageUrlEx;
        public System.String PreviewImageUrlEx { get; set; }

        public override System.Guid[] SiteScriptIds => SiteScriptIdsEx;
        public System.Guid[] SiteScriptIdsEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Int32 Version => VersionEx;
        public System.Int32 VersionEx { get; set; }

        public override System.String WebTemplate => WebTemplateEx;
        public System.String WebTemplateEx { get; set; }

    }
}

