
namespace Microsoft.SharePoint.Client
{
    public class TimeZoneInformationMock : TimeZoneInformation
    {


        public override System.Int32 Bias => BiasEx;
        public System.Int32 BiasEx { get; set; }

        public override System.Int32 DaylightBias => DaylightBiasEx;
        public System.Int32 DaylightBiasEx { get; set; }

        public override System.Int32 StandardBias => StandardBiasEx;
        public System.Int32 StandardBiasEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

