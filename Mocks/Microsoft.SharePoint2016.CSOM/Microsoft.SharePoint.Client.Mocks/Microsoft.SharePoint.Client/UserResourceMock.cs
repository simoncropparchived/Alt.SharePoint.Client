
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class UserResourceMock : UserResource
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetValueForUICulture(System.String @cultureName)
        {
            return GetValueForUICultureEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetValueForUICultureEx { get; set;}

        public override void SetValueForUICulture(System.String @cultureName, System.String @value)
        {
        }

    }
}

