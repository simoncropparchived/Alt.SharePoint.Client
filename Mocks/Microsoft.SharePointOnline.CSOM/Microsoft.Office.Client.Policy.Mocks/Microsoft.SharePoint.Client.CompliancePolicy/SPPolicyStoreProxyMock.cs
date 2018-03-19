
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPPolicyStoreProxyMock : SPPolicyStoreProxy
    {


        public override System.String PolicyStoreUrl => PolicyStoreUrlEx;
        public System.String PolicyStoreUrlEx { get; set; }

        public override System.String ReviewCenterUrl => ReviewCenterUrlEx;
        public System.String ReviewCenterUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> MarkReviewItemsForDeletion(System.Int32[] @itemIds)
        {
            return MarkReviewItemsForDeletionEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> MarkReviewItemsForDeletionEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> RetagReviewItems(System.Int32[] @itemIds, System.String @newTag, System.Boolean @newTagIsRecord, System.Boolean @newTagBlockDelete, System.Boolean @newTagIsEventBased)
        {
            return RetagReviewItemsEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> RetagReviewItemsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> RetagReviewItemsWithMetas(System.Int32[] @itemIds, System.String @newTagName, System.String[] @newTagMetas)
        {
            return RetagReviewItemsWithMetasEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> RetagReviewItemsWithMetasEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> ExtendReviewItemsRetention(System.Int32[] @itemIds, System.DateTime @extensionDate)
        {
            return ExtendReviewItemsRetentionEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.Int32> ExtendReviewItemsRetentionEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> OpenBinaryStreamForOriginalItem(System.Int32 @itemId)
        {
            return OpenBinaryStreamForOriginalItemEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.IO.Stream> OpenBinaryStreamForOriginalItemEx { get; set;}

    }
}

