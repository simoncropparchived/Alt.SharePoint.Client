
namespace Microsoft.Office.SharePoint.Tools
{
    public class LocalizedDisplayNameMock
    {


        public override System.String LCID => LCIDEx;
        public System.String LCIDEx { get; set; }

        public override System.String[] Text => TextEx;
        public System.String[] TextEx { get; set; }

    }
}

