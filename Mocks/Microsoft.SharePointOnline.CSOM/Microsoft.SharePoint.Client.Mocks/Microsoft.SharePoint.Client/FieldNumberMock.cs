
namespace Microsoft.SharePoint.Client
{
    public class FieldNumberMock
    {


        public override System.Int32 DisplayFormat => DisplayFormatEx;
        public System.Int32 DisplayFormatEx { get; set; }

        public override System.Double MaximumValue => MaximumValueEx;
        public System.Double MaximumValueEx { get; set; }

        public override System.Double MinimumValue => MinimumValueEx;
        public System.Double MinimumValueEx { get; set; }

        public override System.Boolean ShowAsPercentage => ShowAsPercentageEx;
        public System.Boolean ShowAsPercentageEx { get; set; }

    }
}

