
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantLogEntryMock
    {


        public override System.Int32 CategoryId => CategoryIdEx;
        public System.Int32 CategoryIdEx { get; set; }

        public override System.Guid CorrelationId => CorrelationIdEx;
        public System.Guid CorrelationIdEx { get; set; }

        public override System.String Message => MessageEx;
        public System.String MessageEx { get; set; }

        public override System.Int32 Source => SourceEx;
        public System.Int32 SourceEx { get; set; }

        public override System.DateTime TimestampUtc => TimestampUtcEx;
        public System.DateTime TimestampUtcEx { get; set; }

        public override System.String User => UserEx;
        public System.String UserEx { get; set; }

    }
}

