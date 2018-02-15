
namespace Microsoft.SharePoint.Client
{
    public class CustomerKeyStatusInfoMock
    {


        public override System.String PrimaryKeyVaultUri => PrimaryKeyVaultUriEx;
        public System.String PrimaryKeyVaultUriEx { get; set; }

        public override System.Boolean RecoveryEnabled => RecoveryEnabledEx;
        public System.Boolean RecoveryEnabledEx { get; set; }

        public override System.String SecondaryKeyVaultUri => SecondaryKeyVaultUriEx;
        public System.String SecondaryKeyVaultUriEx { get; set; }

        public override Microsoft.SharePoint.Client.CustomerKeyStatus Status => StatusEx;
        public Microsoft.SharePoint.Client.CustomerKeyStatus StatusEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

