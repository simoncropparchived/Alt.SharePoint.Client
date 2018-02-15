
namespace Microsoft.Office.SharePoint.Tools
{
    public class IndividuallySecurableMetadataObjectMock : IndividuallySecurableMetadataObject
    {


        public override Microsoft.Office.SharePoint.Tools.AccessControlEntry[] AccessControlList => AccessControlListEx;
        public Microsoft.Office.SharePoint.Tools.AccessControlEntry[] AccessControlListEx { get; set; }

    }
}

