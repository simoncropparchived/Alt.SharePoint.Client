
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedRetrievalOptionsMock : MicrofeedRetrievalOptions
    {


        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedContentFormattingOptions ContentFormattingOption => ContentFormattingOptionEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedContentFormattingOptions ContentFormattingOptionEx { get; set; }

        public override System.Boolean ContentOnly => ContentOnlyEx;
        public System.Boolean ContentOnlyEx { get; set; }

        public override System.Boolean DropAllSecurityTrimmablePosts => DropAllSecurityTrimmablePostsEx;
        public System.Boolean DropAllSecurityTrimmablePostsEx { get; set; }

        public override System.Boolean GatherUnreadMentionCountForUser => GatherUnreadMentionCountForUserEx;
        public System.Boolean GatherUnreadMentionCountForUserEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicroBlogType IncludedTypes => IncludedTypesEx;
        public Microsoft.SharePoint.Client.Microfeed.MicroBlogType IncludedTypesEx { get; set; }

        public override System.DateTime NewerThan => NewerThanEx;
        public System.DateTime NewerThanEx { get; set; }

        public override System.DateTime OlderThan => OlderThanEx;
        public System.DateTime OlderThanEx { get; set; }

        public override System.Collections.Generic.IList`1<System.String> PostDefinitionFilter => PostDefinitionFilterEx;
        public System.Collections.Generic.IList`1<System.String> PostDefinitionFilterEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedSortOrder ResultSortOrder => ResultSortOrderEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedSortOrder ResultSortOrderEx { get; set; }

        public override System.Int32 ThreadCount => ThreadCountEx;
        public System.Int32 ThreadCountEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

