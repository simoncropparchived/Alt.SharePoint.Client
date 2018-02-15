
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantSiteDesignCreationInfoMock : TenantSiteDesignCreationInfo
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

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

        public override System.String WebTemplate => WebTemplateEx;
        public System.String WebTemplateEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

