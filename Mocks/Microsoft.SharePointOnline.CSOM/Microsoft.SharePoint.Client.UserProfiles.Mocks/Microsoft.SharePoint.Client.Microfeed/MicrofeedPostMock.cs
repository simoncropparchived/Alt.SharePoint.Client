
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedPostMock : MicrofeedPost
    {


        public override System.Int32 AuthorIndex => AuthorIndexEx;
        public System.Int32 AuthorIndexEx { get; set; }

        public override System.String BreadCrumb => BreadCrumbEx;
        public System.String BreadCrumbEx { get; set; }

        public override System.Boolean CanDelete => CanDeleteEx;
        public System.Boolean CanDeleteEx { get; set; }

        public override System.Boolean CanFollowUp => CanFollowUpEx;
        public System.Boolean CanFollowUpEx { get; set; }

        public override System.Boolean CanHaveAttachments => CanHaveAttachmentsEx;
        public System.Boolean CanHaveAttachmentsEx { get; set; }

        public override System.Boolean CanLike => CanLikeEx;
        public System.Boolean CanLikeEx { get; set; }

        public override System.Boolean CanLock => CanLockEx;
        public System.Boolean CanLockEx { get; set; }

        public override System.Boolean CanReply => CanReplyEx;
        public System.Boolean CanReplyEx { get; set; }

        public override System.String Content => ContentEx;
        public System.String ContentEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.String Footer => FooterEx;
        public System.String FooterEx { get; set; }

        public override System.String ID => IDEx;
        public System.String IDEx { get; set; }

        public override System.Boolean ILikeIt => ILikeItEx;
        public System.Boolean ILikeItEx { get; set; }

        public override System.Collections.Generic.IList<System.Int32> LikersList => LikersListEx;
        public System.Collections.Generic.IList<System.Int32> LikersListEx { get; set; }

        public override System.Boolean Locked => LockedEx;
        public System.Boolean LockedEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicrofeedLink MediaLink => MediaLinkEx;
        public Microsoft.SharePoint.Client.Microfeed.MicrofeedLink MediaLinkEx { get; set; }

        public override Microsoft.SharePoint.Client.Microfeed.MicroBlogType MicroBlogType => MicroBlogTypeEx;
        public Microsoft.SharePoint.Client.Microfeed.MicroBlogType MicroBlogTypeEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.Int32 PeopleCount => PeopleCountEx;
        public System.Int32 PeopleCountEx { get; set; }

        public override System.String PostImageUri => PostImageUriEx;
        public System.String PostImageUriEx { get; set; }

        public override System.String PostSource => PostSourceEx;
        public System.String PostSourceEx { get; set; }

        public override System.String PostSourceUri => PostSourceUriEx;
        public System.String PostSourceUriEx { get; set; }

        public override System.String ReferenceID => ReferenceIDEx;
        public System.String ReferenceIDEx { get; set; }

        public override System.Boolean RenderPostAuthorImage => RenderPostAuthorImageEx;
        public System.Boolean RenderPostAuthorImageEx { get; set; }

        public override System.Int32 ReplyCount => ReplyCountEx;
        public System.Int32 ReplyCountEx { get; set; }

        public override System.Boolean SmallImageSizePreferred => SmallImageSizePreferredEx;
        public System.Boolean SmallImageSizePreferredEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

