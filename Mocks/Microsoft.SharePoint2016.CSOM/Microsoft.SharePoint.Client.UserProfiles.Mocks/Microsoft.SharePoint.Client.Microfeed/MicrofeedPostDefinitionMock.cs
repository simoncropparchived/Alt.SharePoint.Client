
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedPostDefinitionMock : MicrofeedPostDefinition
    {


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

        public override System.DateTime CreationTime => CreationTimeEx;
        public System.DateTime CreationTimeEx { get; set; }

        public override System.Int64 DefinitionId => DefinitionIdEx;
        public System.Int64 DefinitionIdEx { get; set; }

        public override System.String DefinitionName => DefinitionNameEx;
        public System.String DefinitionNameEx { get; set; }

        public override System.Int32 DefinitionVersion => DefinitionVersionEx;
        public System.Int32 DefinitionVersionEx { get; set; }

        public override System.Boolean EnablePeopleList => EnablePeopleListEx;
        public System.Boolean EnablePeopleListEx { get; set; }

        public override System.Boolean IsDefault => IsDefaultEx;
        public System.Boolean IsDefaultEx { get; set; }

        public override System.Boolean IsEnabled => IsEnabledEx;
        public System.Boolean IsEnabledEx { get; set; }

        public override System.Boolean IsNotification => IsNotificationEx;
        public System.Boolean IsNotificationEx { get; set; }

        public override System.Boolean IsPrivate => IsPrivateEx;
        public System.Boolean IsPrivateEx { get; set; }

        public override System.Boolean IsUserPost => IsUserPostEx;
        public System.Boolean IsUserPostEx { get; set; }

        public override System.DateTime LastUpdateTime => LastUpdateTimeEx;
        public System.DateTime LastUpdateTimeEx { get; set; }

        public override System.Guid PartitionId => PartitionIdEx;
        public System.Guid PartitionIdEx { get; set; }

        public override System.Boolean PersistToCache => PersistToCacheEx;
        public System.Boolean PersistToCacheEx { get; set; }

        public override System.Boolean PersistToPrivateFolder => PersistToPrivateFolderEx;
        public System.Boolean PersistToPrivateFolderEx { get; set; }

        public override System.Boolean PersistToPublishedFeed => PersistToPublishedFeedEx;
        public System.Boolean PersistToPublishedFeedEx { get; set; }

        public override System.String ReferenceLikePostName => ReferenceLikePostNameEx;
        public System.String ReferenceLikePostNameEx { get; set; }

        public override System.String ReferenceMentionPostName => ReferenceMentionPostNameEx;
        public System.String ReferenceMentionPostNameEx { get; set; }

        public override System.String ReferenceReplyPostName => ReferenceReplyPostNameEx;
        public System.String ReferenceReplyPostNameEx { get; set; }

        public override System.Boolean RenderPostAuthorImage => RenderPostAuthorImageEx;
        public System.Boolean RenderPostAuthorImageEx { get; set; }

        public override System.String ResourceFileName => ResourceFileNameEx;
        public System.String ResourceFileNameEx { get; set; }

        public override System.Boolean SecurityTrimContentUrl => SecurityTrimContentUrlEx;
        public System.Boolean SecurityTrimContentUrlEx { get; set; }

        public override System.Boolean SmallImageSizePreferred => SmallImageSizePreferredEx;
        public System.Boolean SmallImageSizePreferredEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

