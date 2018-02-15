
namespace Microsoft.SharePoint.Client
{
    public class TimeZoneMock
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override Microsoft.SharePoint.Client.TimeZoneInformation Information => InformationEx;
        public Microsoft.SharePoint.Client.TimeZoneInformation InformationEx { get; set; }

    }
}

