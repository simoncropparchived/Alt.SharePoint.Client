
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class DlpClassificationResultMock
    {


        public override System.String ClassificationId => ClassificationIdEx;
        public System.String ClassificationIdEx { get; set; }

        public override System.Int32 Confidence => ConfidenceEx;
        public System.Int32 ConfidenceEx { get; set; }

        public override System.Int32 Count => CountEx;
        public System.Int32 CountEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

