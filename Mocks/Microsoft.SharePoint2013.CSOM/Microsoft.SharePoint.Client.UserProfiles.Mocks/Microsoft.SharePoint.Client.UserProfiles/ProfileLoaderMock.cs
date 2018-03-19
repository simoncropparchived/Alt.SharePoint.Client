
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class ProfileLoaderMock : ProfileLoader
    {


        public override Microsoft.SharePoint.Client.UserProfiles.UserProfile GetUserProfile()
        {
            return GetUserProfileEx;
        }
        public Microsoft.SharePoint.Client.UserProfiles.UserProfile GetUserProfileEx { get; set;}

    }
}

