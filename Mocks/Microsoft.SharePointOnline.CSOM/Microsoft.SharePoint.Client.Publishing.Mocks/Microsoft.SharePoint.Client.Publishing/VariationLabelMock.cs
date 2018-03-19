
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Publishing
{
    public class VariationLabelMock : VariationLabel
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.Boolean IsSource => IsSourceEx;
        public System.Boolean IsSourceEx { get; set; }

        public override System.String Language => LanguageEx;
        public System.String LanguageEx { get; set; }

        public override System.String Locale => LocaleEx;
        public System.String LocaleEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TopWebUrl => TopWebUrlEx;
        public System.String TopWebUrlEx { get; set; }

    }
}

