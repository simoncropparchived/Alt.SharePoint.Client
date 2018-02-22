
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class TimeZoneMock : TimeZone
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override Microsoft.SharePoint.Client.TimeZoneInformation Information => InformationEx;
        public Microsoft.SharePoint.Client.TimeZoneInformation InformationEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.DateTime> LocalTimeToUTC(System.DateTime @date)
        {
            return LocalTimeToUTCEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.DateTime> LocalTimeToUTCEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.DateTime> UTCToLocalTime(System.DateTime @date)
        {
            return UTCToLocalTimeEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.DateTime> UTCToLocalTimeEx { get; set;}

    }
}

