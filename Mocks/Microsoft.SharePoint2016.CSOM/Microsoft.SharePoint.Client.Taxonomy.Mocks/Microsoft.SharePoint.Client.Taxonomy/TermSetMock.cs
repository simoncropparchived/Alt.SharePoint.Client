
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermSetMock
    {


        public override System.String Contact => ContactEx;
        public System.String ContactEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermGroup Group => GroupEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermGroup GroupEx { get; set; }

        public override System.Boolean IsOpenForTermCreation => IsOpenForTermCreationEx;
        public System.Boolean IsOpenForTermCreationEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> Stakeholders => StakeholdersEx;
        public System.Collections.Generic.IEnumerable`1<System.String> StakeholdersEx { get; set; }

    }
}

