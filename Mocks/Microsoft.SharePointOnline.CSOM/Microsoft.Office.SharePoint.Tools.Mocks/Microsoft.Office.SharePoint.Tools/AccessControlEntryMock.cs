
namespace Microsoft.Office.SharePoint.Tools
{
    public class AccessControlEntryMock : AccessControlEntry
    {


        public override Microsoft.Office.SharePoint.Tools.Right[] Right => RightEx;
        public Microsoft.Office.SharePoint.Tools.Right[] RightEx { get; set; }

        public override System.String Principal => PrincipalEx;
        public System.String PrincipalEx { get; set; }

    }
}

