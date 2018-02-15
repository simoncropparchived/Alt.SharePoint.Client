
namespace Microsoft.SharePoint.Client
{
    public class WebTemplateMock : WebTemplate
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String DisplayCategory => DisplayCategoryEx;
        public System.String DisplayCategoryEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.String ImageUrl => ImageUrlEx;
        public System.String ImageUrlEx { get; set; }

        public override System.Boolean IsHidden => IsHiddenEx;
        public System.Boolean IsHiddenEx { get; set; }

        public override System.Boolean IsRootWebOnly => IsRootWebOnlyEx;
        public System.Boolean IsRootWebOnlyEx { get; set; }

        public override System.Boolean IsSubWebOnly => IsSubWebOnlyEx;
        public System.Boolean IsSubWebOnlyEx { get; set; }

        public override System.UInt32 Lcid => LcidEx;
        public System.UInt32 LcidEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

    }
}

