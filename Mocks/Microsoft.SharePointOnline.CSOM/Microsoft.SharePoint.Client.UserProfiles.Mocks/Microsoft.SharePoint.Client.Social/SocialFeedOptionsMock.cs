
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialFeedOptionsMock
    {


        public override System.Int32 MaxThreadCount => MaxThreadCountEx;
        public System.Int32 MaxThreadCountEx { get; set; }

        public override System.DateTime NewerThan => NewerThanEx;
        public System.DateTime NewerThanEx { get; set; }

        public override System.DateTime OlderThan => OlderThanEx;
        public System.DateTime OlderThanEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialFeedSortOrder SortOrder => SortOrderEx;
        public Microsoft.SharePoint.Client.Social.SocialFeedSortOrder SortOrderEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

