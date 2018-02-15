
namespace Microsoft.Office.Client.TranslationServices
{
    public class TranslationItemInfoMock : TranslationItemInfo
    {


        public override System.Boolean Canceled => CanceledEx;
        public System.Boolean CanceledEx { get; set; }

        public override System.String ErrorMessage => ErrorMessageEx;
        public System.String ErrorMessageEx { get; set; }

        public override System.Boolean Failed => FailedEx;
        public System.Boolean FailedEx { get; set; }

        public override System.Boolean InProgress => InProgressEx;
        public System.Boolean InProgressEx { get; set; }

        public override System.String InputFile => InputFileEx;
        public System.String InputFileEx { get; set; }

        public override System.Boolean NotStarted => NotStartedEx;
        public System.Boolean NotStartedEx { get; set; }

        public override System.String OutputFile => OutputFileEx;
        public System.String OutputFileEx { get; set; }

        public override Microsoft.Office.Client.TranslationServices.TranslationResult Result => ResultEx;
        public Microsoft.Office.Client.TranslationServices.TranslationResult ResultEx { get; set; }

        public override System.Boolean Succeeded => SucceededEx;
        public System.Boolean SucceededEx { get; set; }

        public override System.Guid TranslationId => TranslationIdEx;
        public System.Guid TranslationIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

