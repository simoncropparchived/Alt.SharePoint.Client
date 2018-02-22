
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class UsageInfoMock : UsageInfo
    {


        public override System.Int64 Bandwidth => BandwidthEx;
        public System.Int64 BandwidthEx { get; set; }

        public override System.Int64 DiscussionStorage => DiscussionStorageEx;
        public System.Int64 DiscussionStorageEx { get; set; }

        public override System.Int64 Hits => HitsEx;
        public System.Int64 HitsEx { get; set; }

        public override System.Int64 Storage => StorageEx;
        public System.Int64 StorageEx { get; set; }

        public override System.Double StoragePercentageUsed => StoragePercentageUsedEx;
        public System.Double StoragePercentageUsedEx { get; set; }

        public override System.Int64 Visits => VisitsEx;
        public System.Int64 VisitsEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

