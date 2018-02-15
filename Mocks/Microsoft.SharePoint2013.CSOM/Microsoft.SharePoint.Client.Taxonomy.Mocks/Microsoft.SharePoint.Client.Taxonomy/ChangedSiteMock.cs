
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class ChangedSiteMock : ChangedSite
    {


        public override System.Guid SiteId => SiteIdEx;
        public System.Guid SiteIdEx { get; set; }

        public override System.Guid TermId => TermIdEx;
        public System.Guid TermIdEx { get; set; }

        public override System.Guid TermSetId => TermSetIdEx;
        public System.Guid TermSetIdEx { get; set; }

    }
}

