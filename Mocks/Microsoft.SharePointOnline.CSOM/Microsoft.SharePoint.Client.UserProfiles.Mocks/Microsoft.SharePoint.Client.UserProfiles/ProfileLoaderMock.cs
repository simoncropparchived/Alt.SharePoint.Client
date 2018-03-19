
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

        public override System.Collections.Generic.IEnumerable<System.String> CreatePersonalSiteEnqueueBulk(System.String[] @emailIDs)
        {
            return CreatePersonalSiteEnqueueBulkEx;
        }
        public System.Collections.Generic.IEnumerable<System.String> CreatePersonalSiteEnqueueBulkEx { get; set;}

    }
}

