
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class PersonalCacheItemMock
    {


        public override System.String CacheKey => CacheKeyEx;
        public System.String CacheKeyEx { get; set; }

        public override System.String CacheValue => CacheValueEx;
        public System.String CacheValueEx { get; set; }

        public override System.String CacheValueHash => CacheValueHashEx;
        public System.String CacheValueHashEx { get; set; }

        public override System.String CacheVersion => CacheVersionEx;
        public System.String CacheVersionEx { get; set; }

        public override System.Int32 ListItemId => ListItemIdEx;
        public System.Int32 ListItemIdEx { get; set; }

        public override System.String ListItemUniqueId => ListItemUniqueIdEx;
        public System.String ListItemUniqueIdEx { get; set; }

        public override System.DateTime ModifiedTimeUtc => ModifiedTimeUtcEx;
        public System.DateTime ModifiedTimeUtcEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

