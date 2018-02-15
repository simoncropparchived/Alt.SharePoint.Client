
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialActorInfoMock
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialActorType ActorType => ActorTypeEx;
        public Microsoft.SharePoint.Client.Social.SocialActorType ActorTypeEx { get; set; }

        public override System.String ContentUri => ContentUriEx;
        public System.String ContentUriEx { get; set; }

        public override System.String Id => IdEx;
        public System.String IdEx { get; set; }

        public override System.Guid TagGuid => TagGuidEx;
        public System.Guid TagGuidEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

