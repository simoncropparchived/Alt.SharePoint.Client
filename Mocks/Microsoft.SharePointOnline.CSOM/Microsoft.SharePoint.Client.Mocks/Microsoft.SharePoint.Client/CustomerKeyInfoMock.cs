
namespace Microsoft.SharePoint.Client
{
    public class CustomerKeyInfoMock
    {


        public override Microsoft.SharePoint.Client.CustomerKeyVaultInfo PrimaryKeyVault => PrimaryKeyVaultEx;
        public Microsoft.SharePoint.Client.CustomerKeyVaultInfo PrimaryKeyVaultEx { get; set; }

        public override Microsoft.SharePoint.Client.CustomerKeyVaultInfo SecondaryKeyVault => SecondaryKeyVaultEx;
        public Microsoft.SharePoint.Client.CustomerKeyVaultInfo SecondaryKeyVaultEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

