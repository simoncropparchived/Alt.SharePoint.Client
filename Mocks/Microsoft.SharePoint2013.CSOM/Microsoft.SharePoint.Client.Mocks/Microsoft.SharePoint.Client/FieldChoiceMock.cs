
namespace Microsoft.SharePoint.Client
{
    public class FieldChoiceMock : FieldChoice
    {


        public override Microsoft.SharePoint.Client.ChoiceFormatType EditFormat => EditFormatEx;
        public Microsoft.SharePoint.Client.ChoiceFormatType EditFormatEx { get; set; }

    }
}

