
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicroBlogEntityMock : MicroBlogEntity
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override System.Boolean CanFollow => CanFollowEx;
        public System.Boolean CanFollowEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicroBlogEntityType EntityType => EntityTypeEx;
        public Microsoft.SharePoint.Client.Microfeed.MicroBlogEntityType EntityTypeEx { get; set; }

        public override System.String EntityURI => EntityURIEx;
        public System.String EntityURIEx { get; set; }

        public override System.String FollowedContentURI => FollowedContentURIEx;
        public System.String FollowedContentURIEx { get; set; }

        public override System.String Identifier => IdentifierEx;
        public System.String IdentifierEx { get; set; }

        public override System.Boolean IsFollowedByMe => IsFollowedByMeEx;
        public System.Boolean IsFollowedByMeEx { get; set; }

        public override System.String LatestPost => LatestPostEx;
        public System.String LatestPostEx { get; set; }

        public override System.String LibraryName => LibraryNameEx;
        public System.String LibraryNameEx { get; set; }

        public override System.String LibraryUri => LibraryUriEx;
        public System.String LibraryUriEx { get; set; }

        public override System.String PersonalURI => PersonalURIEx;
        public System.String PersonalURIEx { get; set; }

        public override System.String PictureURI => PictureURIEx;
        public System.String PictureURIEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode Status => StatusEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode StatusEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

