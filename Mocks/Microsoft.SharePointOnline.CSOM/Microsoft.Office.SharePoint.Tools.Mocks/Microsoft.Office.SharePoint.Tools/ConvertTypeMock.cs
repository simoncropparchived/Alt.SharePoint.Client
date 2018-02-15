
namespace Microsoft.Office.SharePoint.Tools
{
    public class ConvertTypeMock
    {


        public override System.String LOBType => LOBTypeEx;
        public System.String LOBTypeEx { get; set; }

        public override System.String BDCType => BDCTypeEx;
        public System.String BDCTypeEx { get; set; }

        public override System.String LOBLocale => LOBLocaleEx;
        public System.String LOBLocaleEx { get; set; }

    }
}

