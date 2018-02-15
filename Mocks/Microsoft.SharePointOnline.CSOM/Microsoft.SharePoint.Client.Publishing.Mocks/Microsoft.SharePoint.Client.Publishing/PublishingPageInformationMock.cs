
namespace Microsoft.SharePoint.Client.Publishing
{
    public class PublishingPageInformationMock
    {


        public override Microsoft.SharePoint.Client.Folder Folder => FolderEx;
        public Microsoft.SharePoint.Client.Folder FolderEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem PageLayoutListItem => PageLayoutListItemEx;
        public Microsoft.SharePoint.Client.ListItem PageLayoutListItemEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

