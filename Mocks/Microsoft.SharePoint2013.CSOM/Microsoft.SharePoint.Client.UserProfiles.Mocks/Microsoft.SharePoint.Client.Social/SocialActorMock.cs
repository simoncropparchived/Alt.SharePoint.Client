
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialActorMock
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialActorType ActorType => ActorTypeEx;
        public Microsoft.SharePoint.Client.Social.SocialActorType ActorTypeEx { get; set; }

        public override System.Boolean CanFollow => CanFollowEx;
        public System.Boolean CanFollowEx { get; set; }

        public override System.String ContentUri => ContentUriEx;
        public System.String ContentUriEx { get; set; }

        public override System.String EmailAddress => EmailAddressEx;
        public System.String EmailAddressEx { get; set; }

        public override System.String FollowedContentUri => FollowedContentUriEx;
        public System.String FollowedContentUriEx { get; set; }

        public override System.String Id => IdEx;
        public System.String IdEx { get; set; }

        public override System.String ImageUri => ImageUriEx;
        public System.String ImageUriEx { get; set; }

        public override System.Boolean IsFollowed => IsFollowedEx;
        public System.Boolean IsFollowedEx { get; set; }

        public override System.String LibraryUri => LibraryUriEx;
        public System.String LibraryUriEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String PersonalSiteUri => PersonalSiteUriEx;
        public System.String PersonalSiteUriEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialStatusCode Status => StatusEx;
        public Microsoft.SharePoint.Client.Social.SocialStatusCode StatusEx { get; set; }

        public override System.String StatusText => StatusTextEx;
        public System.String StatusTextEx { get; set; }

        public override System.Guid TagGuid => TagGuidEx;
        public System.Guid TagGuidEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String Uri => UriEx;
        public System.String UriEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

