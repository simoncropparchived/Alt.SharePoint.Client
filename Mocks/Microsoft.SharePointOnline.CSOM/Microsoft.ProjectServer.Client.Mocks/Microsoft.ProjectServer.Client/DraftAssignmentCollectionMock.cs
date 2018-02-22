
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class DraftAssignmentCollectionMock : DraftAssignmentCollection
    {


        public override Microsoft.ProjectServer.Client.DraftAssignment GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.DraftAssignment GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftAssignment GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.DraftAssignment GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.DraftAssignment Add(Microsoft.ProjectServer.Client.AssignmentCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.DraftAssignment AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.DraftAssignment @assignment)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

