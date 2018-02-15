
namespace Microsoft.SharePoint.Client
{
    public class FieldCalculatedMock
    {


        public override Microsoft.SharePoint.Client.DateTimeFieldFormatType DateFormat => DateFormatEx;
        public Microsoft.SharePoint.Client.DateTimeFieldFormatType DateFormatEx { get; set; }

        public override System.String Formula => FormulaEx;
        public System.String FormulaEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldType OutputType => OutputTypeEx;
        public Microsoft.SharePoint.Client.FieldType OutputTypeEx { get; set; }

    }
}

