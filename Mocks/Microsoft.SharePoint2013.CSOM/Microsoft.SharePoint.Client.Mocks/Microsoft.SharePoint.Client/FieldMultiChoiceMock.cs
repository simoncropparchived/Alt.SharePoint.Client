
namespace Microsoft.SharePoint.Client
{
    public class FieldMultiChoiceMock : FieldMultiChoice
    {


        public override System.Boolean FillInChoice => FillInChoiceEx;
        public System.Boolean FillInChoiceEx { get; set; }

        public override System.String Mappings => MappingsEx;
        public System.String MappingsEx { get; set; }

        public override System.String[] Choices => ChoicesEx;
        public System.String[] ChoicesEx { get; set; }

    }
}

