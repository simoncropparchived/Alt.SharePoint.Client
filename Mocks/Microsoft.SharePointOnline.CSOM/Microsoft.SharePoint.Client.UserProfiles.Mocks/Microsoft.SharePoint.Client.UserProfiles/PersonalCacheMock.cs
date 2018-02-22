
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class PersonalCacheMock : PersonalCache
    {


        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.PersonalCacheItem[]> ReadCache(System.String @folderPath)
        {
            return ReadCacheEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.PersonalCacheItem[]> ReadCacheEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.PersonalCacheItem[]> ReadCacheOrCreate(Microsoft.SharePoint.Client.ResourcePath @folderPath, System.String[] @requiredCacheKeys, System.Boolean @createIfMissing)
        {
            return ReadCacheOrCreateEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.UserProfiles.PersonalCacheItem[]> ReadCacheOrCreateEx { get; set;}

        public override void WriteCache(Microsoft.SharePoint.Client.UserProfiles.PersonalCacheItem[] @cacheItems)
        {
        }

        public override void LoadUserProfile(System.String @email)
        {
        }

    }
}

