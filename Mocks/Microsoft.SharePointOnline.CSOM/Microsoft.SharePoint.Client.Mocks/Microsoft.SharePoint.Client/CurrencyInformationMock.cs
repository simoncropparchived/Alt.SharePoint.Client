
namespace Microsoft.SharePoint.Client
{
    public class CurrencyInformationMock : CurrencyInformation
    {


        public override System.String DisplayString => DisplayStringEx;
        public System.String DisplayStringEx { get; set; }

        public override System.String LCID => LCIDEx;
        public System.String LCIDEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

