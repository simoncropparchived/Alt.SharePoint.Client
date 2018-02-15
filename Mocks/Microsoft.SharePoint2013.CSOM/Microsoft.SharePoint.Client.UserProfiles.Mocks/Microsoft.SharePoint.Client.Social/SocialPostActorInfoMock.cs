
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialPostActorInfoMock : SocialPostActorInfo
    {


        public override System.Boolean IncludesCurrentUser => IncludesCurrentUserEx;
        public System.Boolean IncludesCurrentUserEx { get; set; }

        public override System.Int32[] Indexes => IndexesEx;
        public System.Int32[] IndexesEx { get; set; }

        public override System.Int32 TotalCount => TotalCountEx;
        public System.Int32 TotalCountEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

