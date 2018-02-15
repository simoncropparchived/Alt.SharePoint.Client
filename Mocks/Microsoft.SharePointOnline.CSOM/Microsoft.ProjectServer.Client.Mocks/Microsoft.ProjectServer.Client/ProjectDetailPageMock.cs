
namespace Microsoft.ProjectServer.Client
{
    public class ProjectDetailPageMock
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItem Item => ItemEx;
        public Microsoft.SharePoint.Client.ListItem ItemEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectDetailPageType PageType => PageTypeEx;
        public Microsoft.ProjectServer.Client.ProjectDetailPageType PageTypeEx { get; set; }

    }
}

