
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class AppErrorEntryMock : AppErrorEntry
    {


        public override System.Guid CorrelationId => CorrelationIdEx;
        public System.Guid CorrelationIdEx { get; set; }

        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.AppErrorType ErrorType => ErrorTypeEx;
        public Microsoft.Online.SharePoint.TenantAdministration.AppErrorType ErrorTypeEx { get; set; }

        public override System.String InstanceUrl => InstanceUrlEx;
        public System.String InstanceUrlEx { get; set; }

        public override System.Guid ProductId => ProductIdEx;
        public System.Guid ProductIdEx { get; set; }

        public override System.DateTime TimeStampInUTC => TimeStampInUTCEx;
        public System.DateTime TimeStampInUTCEx { get; set; }

    }
}

