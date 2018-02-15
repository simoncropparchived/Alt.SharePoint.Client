
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialRestActorMock : SocialRestActor
    {


        public override System.String FollowableItem => FollowableItemEx;
        public System.String FollowableItemEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialActor FollowableItemActor => FollowableItemActorEx;
        public Microsoft.SharePoint.Client.Social.SocialActor FollowableItemActorEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialActor Me => MeEx;
        public Microsoft.SharePoint.Client.Social.SocialActor MeEx { get; set; }

    }
}

