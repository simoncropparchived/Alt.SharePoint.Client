
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class FollowResultMock : FollowResult
    {


        public override Microsoft.SharePoint.Client.UserProfiles.FollowedItem Item => ItemEx;
        public Microsoft.SharePoint.Client.UserProfiles.FollowedItem ItemEx { get; set; }

        public override Microsoft.SharePoint.Client.UserProfiles.FollowResultType ResultType => ResultTypeEx;
        public Microsoft.SharePoint.Client.UserProfiles.FollowResultType ResultTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

