
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantLogMock : TenantLog
    {


        public override System.DateTime LastAvailableTimeInUtc => LastAvailableTimeInUtcEx;
        public System.DateTime LastAvailableTimeInUtcEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntries(System.DateTime @beginDateTimeUtc, System.DateTime @endDateTimeUtc, System.UInt32 @nRows)
        {
            return GetEntriesEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntriesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntriesBySource(System.DateTime @beginDateTimeUtc, System.DateTime @endDateTimeUtc, System.UInt32 @nRows, System.Int32 @source)
        {
            return GetEntriesBySourceEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntriesBySourceEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntriesByUser(System.DateTime @beginDateTimeUtc, System.DateTime @endDateTimeUtc, System.UInt32 @nRows, System.String @user)
        {
            return GetEntriesByUserEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntriesByUserEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntriesByCorrelationId(System.DateTime @beginDateTimeUtc, System.DateTime @endDateTimeUtc, System.UInt32 @nRows, System.Guid @correlationId)
        {
            return GetEntriesByCorrelationIdEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.TenantAdministration.TenantLogEntry> GetEntriesByCorrelationIdEx { get; set;}

    }
}

