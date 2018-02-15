
namespace Microsoft.SharePoint.Client
{
    public class StorageMetricsMock
    {


        public override System.DateTime LastModified => LastModifiedEx;
        public System.DateTime LastModifiedEx { get; set; }

        public override System.Int64 TotalFileCount => TotalFileCountEx;
        public System.Int64 TotalFileCountEx { get; set; }

        public override System.Int64 TotalFileStreamSize => TotalFileStreamSizeEx;
        public System.Int64 TotalFileStreamSizeEx { get; set; }

        public override System.Int64 TotalSize => TotalSizeEx;
        public System.Int64 TotalSizeEx { get; set; }

    }
}

