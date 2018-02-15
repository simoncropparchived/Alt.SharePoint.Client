
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class UserProfilePropertiesForUserMock : UserProfilePropertiesForUser
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

    }
}

