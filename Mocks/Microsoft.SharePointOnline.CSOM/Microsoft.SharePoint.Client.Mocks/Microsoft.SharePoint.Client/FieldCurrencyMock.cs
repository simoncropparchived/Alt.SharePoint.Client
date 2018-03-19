
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldCurrencyMock : FieldCurrency
    {


        public override System.Int32 CurrencyLocaleId => CurrencyLocaleIdEx;
        public System.Int32 CurrencyLocaleIdEx { get; set; }

    }
}

