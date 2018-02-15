
namespace Microsoft.Office.Client.TranslationServices
{
    public class TranslationJobStatusMock
    {


        public override System.Int32 Canceled => CanceledEx;
        public System.Int32 CanceledEx { get; set; }

        public override System.Int32 Count => CountEx;
        public System.Int32 CountEx { get; set; }

        public override System.Int32 Failed => FailedEx;
        public System.Int32 FailedEx { get; set; }

        public override System.Int32 InProgress => InProgressEx;
        public System.Int32 InProgressEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 NotStarted => NotStartedEx;
        public System.Int32 NotStartedEx { get; set; }

        public override System.Int32 Succeeded => SucceededEx;
        public System.Int32 SucceededEx { get; set; }

    }
}

