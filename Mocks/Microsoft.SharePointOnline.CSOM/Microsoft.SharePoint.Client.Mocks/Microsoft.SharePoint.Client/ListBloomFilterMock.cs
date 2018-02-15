
namespace Microsoft.SharePoint.Client
{
    public class ListBloomFilterMock : ListBloomFilter
    {


        public override System.Int32 BloomFilterSize => BloomFilterSizeEx;
        public System.Int32 BloomFilterSizeEx { get; set; }

        public override System.Double FalsePositiveRate => FalsePositiveRateEx;
        public System.Double FalsePositiveRateEx { get; set; }

        public override System.Collections.Generic.IList<System.String> HashedValueSet => HashedValueSetEx;
        public System.Collections.Generic.IList<System.String> HashedValueSetEx { get; set; }

        public override System.Collections.Generic.IList<System.Int32> IndexMap => IndexMapEx;
        public System.Collections.Generic.IList<System.Int32> IndexMapEx { get; set; }

        public override System.Int32 ItemProcessedCount => ItemProcessedCountEx;
        public System.Int32 ItemProcessedCountEx { get; set; }

        public override System.Int32 K => KEx;
        public System.Int32 KEx { get; set; }

        public override System.Int32 LastListItemIdProcessed => LastListItemIdProcessedEx;
        public System.Int32 LastListItemIdProcessedEx { get; set; }

        public override System.Int32 MaxItemCount => MaxItemCountEx;
        public System.Int32 MaxItemCountEx { get; set; }

    }
}

