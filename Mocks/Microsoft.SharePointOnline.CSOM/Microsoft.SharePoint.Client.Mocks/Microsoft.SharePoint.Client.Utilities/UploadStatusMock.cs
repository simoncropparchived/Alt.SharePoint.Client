
namespace Microsoft.SharePoint.Client.Utilities
{
    public class UploadStatusMock : UploadStatus
    {


        public override System.String ExpectedContentRange => ExpectedContentRangeEx;
        public System.String ExpectedContentRangeEx { get; set; }

        public override System.DateTime ExpirationDateTime => ExpirationDateTimeEx;
        public System.DateTime ExpirationDateTimeEx { get; set; }

        public override System.Guid UploadId => UploadIdEx;
        public System.Guid UploadIdEx { get; set; }

    }
}

