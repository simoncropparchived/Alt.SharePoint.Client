
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class FollowedItemDataMock : FollowedItemData
    {


        public override System.Collections.Generic.IDictionary<System.String, System.Object> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary<System.String, System.Object> PropertiesEx { get; set; }

    }
}

