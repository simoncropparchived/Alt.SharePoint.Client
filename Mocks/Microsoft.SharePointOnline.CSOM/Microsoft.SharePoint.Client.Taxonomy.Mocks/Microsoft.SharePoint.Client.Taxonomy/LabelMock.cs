
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class LabelMock : Label
    {


        public override System.Boolean IsDefaultForLanguage => IsDefaultForLanguageEx;
        public System.Boolean IsDefaultForLanguageEx { get; set; }

        public override System.Int32 Language => LanguageEx;
        public System.Int32 LanguageEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.Term Term => TermEx;
        public Microsoft.SharePoint.Client.Taxonomy.Term TermEx { get; set; }

        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

    }
}

