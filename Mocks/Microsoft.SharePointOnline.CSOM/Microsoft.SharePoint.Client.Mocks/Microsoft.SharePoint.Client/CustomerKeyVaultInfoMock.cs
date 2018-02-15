
namespace Microsoft.SharePoint.Client
{
    public class CustomerKeyVaultInfoMock : CustomerKeyVaultInfo
    {


        public override System.String KeyName => KeyNameEx;
        public System.String KeyNameEx { get; set; }

        public override System.Guid KeyVersion => KeyVersionEx;
        public System.Guid KeyVersionEx { get; set; }

        public override System.String VaultName => VaultNameEx;
        public System.String VaultNameEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

