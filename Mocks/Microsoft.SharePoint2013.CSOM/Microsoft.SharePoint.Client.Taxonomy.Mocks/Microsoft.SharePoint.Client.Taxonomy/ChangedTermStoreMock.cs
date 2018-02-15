
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class ChangedTermStoreMock : ChangedTermStore
    {


        public override System.Int32 ChangedLanguage => ChangedLanguageEx;
        public System.Int32 ChangedLanguageEx { get; set; }

        public override System.Boolean IsDefaultLanguageChanged => IsDefaultLanguageChangedEx;
        public System.Boolean IsDefaultLanguageChangedEx { get; set; }

        public override System.Boolean IsFullFarmRestore => IsFullFarmRestoreEx;
        public System.Boolean IsFullFarmRestoreEx { get; set; }

    }
}

