
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Social
{
    public class SocialThreadMock : SocialThread
    {


        public override Microsoft.SharePoint.Client.Social.SocialActor[] Actors => ActorsEx;
        public Microsoft.SharePoint.Client.Social.SocialActor[] ActorsEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialThreadAttributes Attributes => AttributesEx;
        public Microsoft.SharePoint.Client.Social.SocialThreadAttributes AttributesEx { get; set; }

        public override System.String Id => IdEx;
        public System.String IdEx { get; set; }

        public override System.Int32 OwnerIndex => OwnerIndexEx;
        public System.Int32 OwnerIndexEx { get; set; }

        public override System.String Permalink => PermalinkEx;
        public System.String PermalinkEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPostReference PostReference => PostReferenceEx;
        public Microsoft.SharePoint.Client.Social.SocialPostReference PostReferenceEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPost[] Replies => RepliesEx;
        public Microsoft.SharePoint.Client.Social.SocialPost[] RepliesEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialPost RootPost => RootPostEx;
        public Microsoft.SharePoint.Client.Social.SocialPost RootPostEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialStatusCode Status => StatusEx;
        public Microsoft.SharePoint.Client.Social.SocialStatusCode StatusEx { get; set; }

        public override Microsoft.SharePoint.Client.Social.SocialThreadType ThreadType => ThreadTypeEx;
        public Microsoft.SharePoint.Client.Social.SocialThreadType ThreadTypeEx { get; set; }

        public override System.Int32 TotalReplyCount => TotalReplyCountEx;
        public System.Int32 TotalReplyCountEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

