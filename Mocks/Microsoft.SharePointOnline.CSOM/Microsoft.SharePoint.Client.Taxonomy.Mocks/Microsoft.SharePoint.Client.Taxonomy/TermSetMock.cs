
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermSetMock : TermSet
    {


        public override System.String Contact => ContactEx;
        public System.String ContactEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup Group => GroupEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup GroupEx { get; set; }

        public override System.Boolean IsOpenForTermCreation => IsOpenForTermCreationEx;
        public System.Boolean IsOpenForTermCreationEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String, System.String> Names => NamesEx;
        public System.Collections.Generic.IDictionary<System.String, System.String> NamesEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.String> Stakeholders => StakeholdersEx;
        public System.Collections.Generic.IEnumerable<System.String> StakeholdersEx { get; set; }

        public override void AddStakeholder(System.String @stakeholderName)
        {
        }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet Copy()
        {
            return CopyEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSet CopyEx { get; set;}

        public override void DeleteStakeholder(System.String @stakeholderName)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ExportObject()
        {
            return ExportObjectEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ExportObjectEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetAllTerms()
        {
            return GetAllTermsEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetAllTermsEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetAllTermsIncludeDeprecated()
        {
            return GetAllTermsIncludeDeprecatedEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetAllTermsIncludeDeprecatedEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.ChangedItemCollection GetChanges(Microsoft.SharePoint.Client.Taxonomy.ChangeInformation @changeInformation)
        {
            return GetChangesEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.ChangedItemCollection GetChangesEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term GetTerm(System.Guid @termId)
        {
            return GetTermEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term GetTermEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTerms(Microsoft.SharePoint.Client.Taxonomy.LabelMatchInformation @labelMatchInformation)
        {
            return GetTermsEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsWithCustomProperty(Microsoft.SharePoint.Client.Taxonomy.CustomPropertyMatchInformation @customPropertyMatchInformation)
        {
            return GetTermsWithCustomPropertyEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection GetTermsWithCustomPropertyEx { get; set;}

        public override void Move(Microsoft.SharePoint.Client.Taxonomy.TermGroup @targetGroup)
        {
        }

    }
}

