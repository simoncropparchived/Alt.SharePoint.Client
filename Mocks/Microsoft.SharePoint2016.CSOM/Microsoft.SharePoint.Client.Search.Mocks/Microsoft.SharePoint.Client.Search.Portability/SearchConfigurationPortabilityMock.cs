
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Search.Portability
{
    public class SearchConfigurationPortabilityMock : SearchConfigurationPortability
    {


        public override System.String ImportWarnings => ImportWarningsEx;
        public System.String ImportWarningsEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ExportSearchConfiguration(Microsoft.SharePoint.Client.Search.Administration.SearchObjectOwner @owningScope)
        {
            return ExportSearchConfigurationEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ExportSearchConfigurationEx { get; set;}

        public override void ImportSearchConfiguration(Microsoft.SharePoint.Client.Search.Administration.SearchObjectOwner @owningScope, System.String @searchConfiguration)
        {
        }

        public override void DeleteSearchConfiguration(Microsoft.SharePoint.Client.Search.Administration.SearchObjectOwner @owningScope, System.String @searchConfiguration)
        {
        }

    }
}

