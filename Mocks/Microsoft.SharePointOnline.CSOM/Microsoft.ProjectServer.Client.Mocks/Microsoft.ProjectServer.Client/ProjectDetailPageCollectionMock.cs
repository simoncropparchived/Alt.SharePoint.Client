
namespace Microsoft.ProjectServer.Client
{
    public class ProjectDetailPageCollectionMock : ProjectDetailPageCollection
    {


        public override Microsoft.SharePoint.Client.List List => ListEx;
        public Microsoft.SharePoint.Client.List ListEx { get; set; }

    }
}

