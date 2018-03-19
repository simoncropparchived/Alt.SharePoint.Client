
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ProjectDetailPageCollectionMock : ProjectDetailPageCollection
    {


        public override Microsoft.SharePoint.Client.List List => ListEx;
        public Microsoft.SharePoint.Client.List ListEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectDetailPage GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.ProjectDetailPage GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.ProjectDetailPage GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.ProjectDetailPage GetByGuidEx { get; set;}

    }
}

