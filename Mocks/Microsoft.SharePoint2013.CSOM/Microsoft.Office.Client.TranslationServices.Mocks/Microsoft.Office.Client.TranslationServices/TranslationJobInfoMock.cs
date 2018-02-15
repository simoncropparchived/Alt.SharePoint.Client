
namespace Microsoft.Office.Client.TranslationServices
{
    public class TranslationJobInfoMock : TranslationJobInfo
    {


        public override System.Boolean Canceled => CanceledEx;
        public System.Boolean CanceledEx { get; set; }

        public override System.DateTime CancelTime => CancelTimeEx;
        public System.DateTime CancelTimeEx { get; set; }

        public override System.Guid JobId => JobIdEx;
        public System.Guid JobIdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Boolean PartiallySubmitted => PartiallySubmittedEx;
        public System.Boolean PartiallySubmittedEx { get; set; }

        public override System.DateTime SubmittedTime => SubmittedTimeEx;
        public System.DateTime SubmittedTimeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

