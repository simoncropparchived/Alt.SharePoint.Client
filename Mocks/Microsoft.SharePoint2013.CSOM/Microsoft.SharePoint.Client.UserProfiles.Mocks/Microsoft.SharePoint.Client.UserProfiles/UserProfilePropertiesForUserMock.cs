
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class UserProfilePropertiesForUserMock : UserProfilePropertiesForUser
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetPropertyNames()
        {
            return GetPropertyNamesEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetPropertyNamesEx { get; set;}

    }
}

