
namespace Microsoft.SharePoint.Client
{
    public class ChangeItemMock
    {


        public override Microsoft.SharePoint.Client.SPChangeActivityType ActivityType => ActivityTypeEx;
        public Microsoft.SharePoint.Client.SPChangeActivityType ActivityTypeEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentTypeId ContentTypeId => ContentTypeIdEx;
        public Microsoft.SharePoint.Client.ContentTypeId ContentTypeIdEx { get; set; }

        public override System.String Editor => EditorEx;
        public System.String EditorEx { get; set; }

        public override System.String EditorEmailHint => EditorEmailHintEx;
        public System.String EditorEmailHintEx { get; set; }

        public override System.String EditorLoginName => EditorLoginNameEx;
        public System.String EditorLoginNameEx { get; set; }

        public override Microsoft.SharePoint.Client.FileSystemObjectType FileSystemObjectType => FileSystemObjectTypeEx;
        public Microsoft.SharePoint.Client.FileSystemObjectType FileSystemObjectTypeEx { get; set; }

        public override System.String FileType => FileTypeEx;
        public System.String FileTypeEx { get; set; }

        public override System.String Hashtag => HashtagEx;
        public System.String HashtagEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Int32 ItemId => ItemIdEx;
        public System.Int32 ItemIdEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override Microsoft.SharePoint.Client.ListTemplateType ListTemplate => ListTemplateEx;
        public Microsoft.SharePoint.Client.ListTemplateType ListTemplateEx { get; set; }

        public override System.String ListTitle => ListTitleEx;
        public System.String ListTitleEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.SharedWithUser SharedByUser => SharedByUserEx;
        public Microsoft.SharePoint.Client.SharedWithUser SharedByUserEx { get; set; }

        public override Microsoft.SharePoint.Client.SharedWithUserCollection SharedWithUsers => SharedWithUsersEx;
        public Microsoft.SharePoint.Client.SharedWithUserCollection SharedWithUsersEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Guid UniqueId => UniqueIdEx;
        public System.Guid UniqueIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

