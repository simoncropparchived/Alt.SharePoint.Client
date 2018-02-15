
namespace Microsoft.SharePoint.Client
{
    public class ServerExceptionMock : ServerException
    {


        public override System.String ServerStackTrace => ServerStackTraceEx;
        public System.String ServerStackTraceEx { get; set; }

        public override System.Int32 ServerErrorCode => ServerErrorCodeEx;
        public System.Int32 ServerErrorCodeEx { get; set; }

        public override System.String ServerErrorValue => ServerErrorValueEx;
        public System.String ServerErrorValueEx { get; set; }

        public override System.String ServerErrorTypeName => ServerErrorTypeNameEx;
        public System.String ServerErrorTypeNameEx { get; set; }

        public override System.Object ServerErrorDetails => ServerErrorDetailsEx;
        public System.Object ServerErrorDetailsEx { get; set; }

        public override System.String ServerErrorTraceCorrelationId => ServerErrorTraceCorrelationIdEx;
        public System.String ServerErrorTraceCorrelationIdEx { get; set; }

    }
}

