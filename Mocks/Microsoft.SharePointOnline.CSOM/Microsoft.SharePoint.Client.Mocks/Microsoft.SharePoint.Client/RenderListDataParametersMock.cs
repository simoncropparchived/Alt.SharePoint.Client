
namespace Microsoft.SharePoint.Client
{
    public class RenderListDataParametersMock : RenderListDataParameters
    {


        public override System.Boolean AddRequiredFields => AddRequiredFieldsEx;
        public System.Boolean AddRequiredFieldsEx { get; set; }

        public override System.Boolean AllowMultipleValueFilterForTaxonomyFields => AllowMultipleValueFilterForTaxonomyFieldsEx;
        public System.Boolean AllowMultipleValueFilterForTaxonomyFieldsEx { get; set; }

        public override System.Boolean DatesInUtc => DatesInUtcEx;
        public System.Boolean DatesInUtcEx { get; set; }

        public override System.Boolean ExpandGroups => ExpandGroupsEx;
        public System.Boolean ExpandGroupsEx { get; set; }

        public override System.Boolean FirstGroupOnly => FirstGroupOnlyEx;
        public System.Boolean FirstGroupOnlyEx { get; set; }

        public override System.String FolderServerRelativeUrl => FolderServerRelativeUrlEx;
        public System.String FolderServerRelativeUrlEx { get; set; }

        public override System.String ImageFieldsToTryRewriteToCdnUrls => ImageFieldsToTryRewriteToCdnUrlsEx;
        public System.String ImageFieldsToTryRewriteToCdnUrlsEx { get; set; }

        public override System.String OverrideViewXml => OverrideViewXmlEx;
        public System.String OverrideViewXmlEx { get; set; }

        public override System.String Paging => PagingEx;
        public System.String PagingEx { get; set; }

        public override Microsoft.SharePoint.Client.RenderListDataOptions RenderOptions => RenderOptionsEx;
        public Microsoft.SharePoint.Client.RenderListDataOptions RenderOptionsEx { get; set; }

        public override System.Boolean ReplaceGroup => ReplaceGroupEx;
        public System.Boolean ReplaceGroupEx { get; set; }

        public override System.String ViewXml => ViewXmlEx;
        public System.String ViewXmlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

