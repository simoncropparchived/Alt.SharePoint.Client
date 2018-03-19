
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermStoreMock : TermStore
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

        public override System.Collections.Generic.IEnumerable<System.Int32> Languages => LanguagesEx;
        public System.Collections.Generic.IEnumerable<System.Int32> LanguagesEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet OrphanedTermsTermSet => OrphanedTermsTermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet OrphanedTermsTermSetEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup SystemGroup => SystemGroupEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup SystemGroupEx { get; set; }

        public override System.Int32 WorkingLanguage => WorkingLanguageEx;
        public System.Int32 WorkingLanguageEx { get; set; }

        public override void AddLanguage(System.Int32 @lcid)
        {
        }

        public override void CommitAll()
        {
        }

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup CreateGroup(System.String @name, System.Guid @groupId)
        {
            return CreateGroupEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup CreateGroupEx { get; set;}

        public override void DeleteLanguage(System.Int32 @lcid)
        {
        }

        public override Microsoft.SharePoint.Client.Taxonomy.ChangedItemCollection GetChanges(Microsoft.SharePoint.Client.Taxonomy.ChangeInformation @changeInformation)
        {
            return GetChangesEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.ChangedItemCollection GetChangesEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup GetGroup(System.Guid @id)
        {
            return GetGroupEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup GetGroupEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term GetTerm(System.Guid @termId)
        {
            return GetTermEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term GetTermEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term GetTermInTermSet(System.Guid @termSetId, System.Guid @termId)
        {
            return GetTermInTermSetEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term GetTermInTermSetEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsById(System.Guid[] @termIds)
        {
            return GetTermsByIdEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsByIdEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTerms(Microsoft.SharePoint.Client.Taxonomy.LabelMatchInformation @labelMatchInformation)
        {
            return GetTermsEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByName(System.String @termSetName, System.Int32 @lcid)
        {
            return GetTermSetsByNameEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByNameEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsWithCustomProperty(Microsoft.SharePoint.Client.Taxonomy.CustomPropertyMatchInformation @customPropertyMatchInformation)
        {
            return GetTermsWithCustomPropertyEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsWithCustomPropertyEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet GetTermSet(System.Guid @termSetId)
        {
            return GetTermSetEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSet GetTermSetEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByTermLabel(System.String[] @requiredTermLabels, System.Int32 @lcid)
        {
            return GetTermSetsByTermLabelEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsByTermLabelEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsWithCustomProperty(Microsoft.SharePoint.Client.Taxonomy.CustomPropertyMatchInformation @customPropertyMatchInformation)
        {
            return GetTermSetsWithCustomPropertyEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsWithCustomPropertyEx { get; set;}

        public override void RollbackAll()
        {
        }

        public override void UpdateCache()
        {
        }

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup GetSiteCollectionGroup(Microsoft.SharePoint.Client.Site @currentSite, System.Boolean @createIfMissing)
        {
            return GetSiteCollectionGroupEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup GetSiteCollectionGroupEx { get; set;}

        public override void UpdateUsedTermsOnSite(Microsoft.SharePoint.Client.Site @site)
        {
        }

    }
}

