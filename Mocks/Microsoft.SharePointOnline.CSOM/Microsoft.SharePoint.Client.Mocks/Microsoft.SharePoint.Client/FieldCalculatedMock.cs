
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldCalculatedMock : FieldCalculated
    {


        public override System.Int32 CurrencyLocaleId => CurrencyLocaleIdEx;
        public System.Int32 CurrencyLocaleIdEx { get; set; }

        public override Microsoft.SharePoint.Client.DateTimeFieldFormatType DateFormat => DateFormatEx;
        public Microsoft.SharePoint.Client.DateTimeFieldFormatType DateFormatEx { get; set; }

        public override System.Int32 DisplayFormat => DisplayFormatEx;
        public System.Int32 DisplayFormatEx { get; set; }

        public override System.String Formula => FormulaEx;
        public System.String FormulaEx { get; set; }

        public override Microsoft.SharePoint.Client.FieldType OutputType => OutputTypeEx;
        public Microsoft.SharePoint.Client.FieldType OutputTypeEx { get; set; }

        public override System.Boolean ShowAsPercentage => ShowAsPercentageEx;
        public System.Boolean ShowAsPercentageEx { get; set; }

    }
}

