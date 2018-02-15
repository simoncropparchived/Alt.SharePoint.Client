
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermStoreMock
    {


        public override System.String ContentTypePublishingHub => ContentTypePublishingHubEx;
        public System.String ContentTypePublishingHubEx { get; set; }

        public override System.Int32 DefaultLanguage => DefaultLanguageEx;
        public System.Int32 DefaultLanguageEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroupCollection Groups => GroupsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermGroupCollection GroupsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet HashTagsTermSet => HashTagsTermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet HashTagsTermSetEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean IsOnline => IsOnlineEx;
        public System.Boolean IsOnlineEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet KeywordsTermSet => KeywordsTermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet KeywordsTermSetEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.Int32> Languages => LanguagesEx;
        public System.Collections.Generic.IEnumerable`1<System.Int32> LanguagesEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet OrphanedTermsTermSet => OrphanedTermsTermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet OrphanedTermsTermSetEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup SystemGroup => SystemGroupEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup SystemGroupEx { get; set; }

        public override System.Int32 WorkingLanguage => WorkingLanguageEx;
        public System.Int32 WorkingLanguageEx { get; set; }

    }
}

