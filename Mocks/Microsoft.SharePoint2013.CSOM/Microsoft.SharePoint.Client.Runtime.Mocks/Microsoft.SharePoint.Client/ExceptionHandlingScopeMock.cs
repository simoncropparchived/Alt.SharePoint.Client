
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ExceptionHandlingScopeMock : ExceptionHandlingScope
    {


        public override System.Boolean Processed => ProcessedEx;
        public System.Boolean ProcessedEx { get; set; }

        public override System.Boolean HasException => HasExceptionEx;
        public System.Boolean HasExceptionEx { get; set; }

        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

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

        public override System.IDisposable StartScope()
        {
            return StartScopeEx;
        }
        public System.IDisposable StartScopeEx { get; set;}

        public override System.IDisposable StartTry()
        {
            return StartTryEx;
        }
        public System.IDisposable StartTryEx { get; set;}

        public override System.IDisposable StartCatch()
        {
            return StartCatchEx;
        }
        public System.IDisposable StartCatchEx { get; set;}

        public override System.IDisposable StartFinally()
        {
            return StartFinallyEx;
        }
        public System.IDisposable StartFinallyEx { get; set;}

    }
}

