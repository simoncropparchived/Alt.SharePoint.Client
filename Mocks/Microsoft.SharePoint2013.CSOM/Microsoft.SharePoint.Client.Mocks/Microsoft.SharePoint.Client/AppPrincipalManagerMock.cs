
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class AppPrincipalManagerMock : AppPrincipalManager
    {


        public override Microsoft.SharePoint.Client.AppPrincipal LookupAppPrincipal(Microsoft.SharePoint.Client.AppPrincipalIdentityProvider @identityProvider, Microsoft.SharePoint.Client.AppPrincipalName @appPrincipalName)
        {
            return LookupAppPrincipalEx;
        }
        public Microsoft.SharePoint.Client.AppPrincipal LookupAppPrincipalEx { get; set;}

        public override void DeleteAppPrincipal(Microsoft.SharePoint.Client.AppPrincipal @appPrincipal)
        {
        }

        public override void AddAppPrincipalCredential(Microsoft.SharePoint.Client.AppPrincipal @appPrincipal, Microsoft.SharePoint.Client.AppPrincipalCredential @credential)
        {
        }

        public override Microsoft.SharePoint.Client.AppPrincipal CreateAppPrincipal(Microsoft.SharePoint.Client.ExternalAppPrincipalCreationParameters @parameters)
        {
            return CreateAppPrincipalEx;
        }
        public Microsoft.SharePoint.Client.AppPrincipal CreateAppPrincipalEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.AppPrincipalConfiguration> GetAppPrincipalConfiguration(Microsoft.SharePoint.Client.AppPrincipal @appPrincipal)
        {
            return GetAppPrincipalConfigurationEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.AppPrincipalConfiguration> GetAppPrincipalConfigurationEx { get; set;}

        public override void SetAppPrincipalConfiguration(Microsoft.SharePoint.Client.AppPrincipalConfiguration @appPrincipalConfiguration)
        {
        }

        public override System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.AppPrincipalCredentialReference> GetAppPrincipalCredentials(Microsoft.SharePoint.Client.AppPrincipal @appPrincipal)
        {
            return GetAppPrincipalCredentialsEx;
        }
        public System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.AppPrincipalCredentialReference> GetAppPrincipalCredentialsEx { get; set;}

        public override void DeleteAppPrincipalCredential(Microsoft.SharePoint.Client.AppPrincipalCredentialReference @credentialReference)
        {
        }

    }
}

