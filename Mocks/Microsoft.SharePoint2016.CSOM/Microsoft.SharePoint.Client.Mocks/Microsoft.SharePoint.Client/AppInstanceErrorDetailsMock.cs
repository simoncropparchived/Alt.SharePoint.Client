
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AppInstanceErrorDetailsMock : AppInstanceErrorDetails
    {


        public override System.Guid CorrelationId => CorrelationIdEx;
        public System.Guid CorrelationIdEx { get; set; }

        public override System.String ErrorDetail => ErrorDetailEx;
        public System.String ErrorDetailEx { get; set; }

        public override Microsoft.SharePoint.Client.AppInstanceErrorType ErrorType => ErrorTypeEx;
        public Microsoft.SharePoint.Client.AppInstanceErrorType ErrorTypeEx { get; set; }

        public override System.String ErrorTypeName => ErrorTypeNameEx;
        public System.String ErrorTypeNameEx { get; set; }

        public override System.String ExceptionMessage => ExceptionMessageEx;
        public System.String ExceptionMessageEx { get; set; }

        public override Microsoft.SharePoint.Client.AppInstanceErrorSource Source => SourceEx;
        public Microsoft.SharePoint.Client.AppInstanceErrorSource SourceEx { get; set; }

        public override System.String SourceName => SourceNameEx;
        public System.String SourceNameEx { get; set; }

    }
}

