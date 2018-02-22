
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PlanAssignmentCollectionMock : PlanAssignmentCollection
    {


        public override Microsoft.ProjectServer.Client.PlanAssignment GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.PlanAssignment GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.PlanAssignment GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.PlanAssignment GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.PlanAssignment Add(Microsoft.ProjectServer.Client.PlanAssignmentCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.PlanAssignment AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.PlanAssignment @assignment)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

    }
}

