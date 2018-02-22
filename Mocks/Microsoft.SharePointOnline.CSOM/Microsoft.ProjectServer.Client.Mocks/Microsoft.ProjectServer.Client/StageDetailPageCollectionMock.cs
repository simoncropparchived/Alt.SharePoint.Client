
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StageDetailPageCollectionMock : StageDetailPageCollection
    {


        public override Microsoft.ProjectServer.Client.StageDetailPage GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.StageDetailPage GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.StageDetailPage GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.StageDetailPage GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.StageDetailPage Add(Microsoft.ProjectServer.Client.StageDetailPageCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.StageDetailPage AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.StageDetailPage @pdp)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

