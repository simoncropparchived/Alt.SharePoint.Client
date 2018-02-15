
namespace Microsoft.Office.Client.TranslationServices
{
    public class TranslationJobMock : TranslationJob
    {


        public override System.Guid JobId => JobIdEx;
        public System.Guid JobIdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehavior => OutputSaveBehaviorEx;
        public Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehaviorEx { get; set; }

    }
}

