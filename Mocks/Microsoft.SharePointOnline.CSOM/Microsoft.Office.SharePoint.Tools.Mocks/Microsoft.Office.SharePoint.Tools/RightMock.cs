
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class RightMock : Right
    {


        public override Microsoft.Office.SharePoint.Tools.BdcRightName BdcRight => BdcRightEx;
        public Microsoft.Office.SharePoint.Tools.BdcRightName BdcRightEx { get; set; }

    }
}

