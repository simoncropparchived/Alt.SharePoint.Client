
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldNumberMock : FieldNumber
    {


        public override System.Double MaximumValue => MaximumValueEx;
        public System.Double MaximumValueEx { get; set; }

        public override System.Double MinimumValue => MinimumValueEx;
        public System.Double MinimumValueEx { get; set; }

    }
}

