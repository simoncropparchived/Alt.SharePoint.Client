
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class SecondaryAdministratorsFieldsDataMock : SecondaryAdministratorsFieldsData
    {


        public override System.String[] secondaryAdministratorEmails => secondaryAdministratorEmailsEx;
        public System.String[] secondaryAdministratorEmailsEx { get; set; }

        public override System.Guid siteId => siteIdEx;
        public System.Guid siteIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

