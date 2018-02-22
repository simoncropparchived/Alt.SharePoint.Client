
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedThreadMock : MicrofeedThread
    {


        public override System.Boolean CanFollowUp => CanFollowUpEx;
        public System.Boolean CanFollowUpEx { get; set; }

        public override System.Boolean CanHaveAttachments => CanHaveAttachmentsEx;
        public System.Boolean CanHaveAttachmentsEx { get; set; }

        public override System.Boolean CanLike => CanLikeEx;
        public System.Boolean CanLikeEx { get; set; }

        public override System.Boolean CanReply => CanReplyEx;
        public System.Boolean CanReplyEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.Microfeed.MicrofeedDataLink> DataLinks => DataLinksEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.Microfeed.MicrofeedDataLink> DataLinksEx { get; set; }

        public override System.Int64 DefinitionId => DefinitionIdEx;
        public System.Int64 DefinitionIdEx { get; set; }

        public override System.String DefinitionName => DefinitionNameEx;
        public System.String DefinitionNameEx { get; set; }

        public override System.String Identifier => IdentifierEx;
        public System.String IdentifierEx { get; set; }

        public override System.Boolean Locked => LockedEx;
        public System.Boolean LockedEx { get; set; }

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.Microfeed.MicroBlogEntity> MicrofeedEntities => MicrofeedEntitiesEx;
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.Microfeed.MicroBlogEntity> MicrofeedEntitiesEx { get; set; }

        public override System.Int32 OwnerIndex => OwnerIndexEx;
        public System.Int32 OwnerIndexEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedPost RefReply => RefReplyEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedPost RefReplyEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedPost RefRoot => RefRootEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedPost RefRootEx { get; set; }

        public override System.Boolean RenderPostAuthorImage => RenderPostAuthorImageEx;
        public System.Boolean RenderPostAuthorImageEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedPostCollection Replies => RepliesEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedPostCollection RepliesEx { get; set; }

        public override System.Int32 ReplyCount => ReplyCountEx;
        public System.Int32 ReplyCountEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedPost RootPost => RootPostEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedPost RootPostEx { get; set; }

        public override System.Boolean SmallImageSizePreferred => SmallImageSizePreferredEx;
        public System.Boolean SmallImageSizePreferredEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode Status => StatusEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedStatusCode StatusEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

