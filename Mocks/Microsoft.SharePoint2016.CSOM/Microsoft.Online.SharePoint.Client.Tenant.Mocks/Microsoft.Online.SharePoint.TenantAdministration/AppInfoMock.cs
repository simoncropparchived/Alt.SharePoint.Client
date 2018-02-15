
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class AppInfoMock : AppInfo
    {


        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Guid ProductId => ProductIdEx;
        public System.Guid ProductIdEx { get; set; }

        public override Microsoft.Online.SharePoint.TenantAdministration.AppSource Source => SourceEx;
        public Microsoft.Online.SharePoint.TenantAdministration.AppSource SourceEx { get; set; }

    }
}

