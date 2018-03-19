
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class DraftTaskLinkCollectionMock : DraftTaskLinkCollection
    {


        public override Microsoft.ProjectServer.Client.DraftTaskLink GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.DraftTaskLink GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftTaskLink GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.DraftTaskLink GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftTaskLink Add(Microsoft.ProjectServer.Client.TaskLinkCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.DraftTaskLink AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.DraftTaskLink @TaskLink)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

