
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StatusAssignmentCollectionMock : StatusAssignmentCollection
    {


        public override Microsoft.ProjectServer.Client.TimePhase GetTimePhase(System.DateTime @start, System.DateTime @end)
        {
            return GetTimePhaseEx;
        }
        public Microsoft.ProjectServer.Client.TimePhase GetTimePhaseEx { get; set;}

        public override Microsoft.ProjectServer.Client.StatusAssignment GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.StatusAssignment GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.StatusAssignment GetByGuid(System.Guid @uid)
        {
            return GetByGuidEx;
        }
        public Microsoft.ProjectServer.Client.StatusAssignment GetByGuidEx { get; set;}

        public override Microsoft.ProjectServer.Client.StatusAssignment Add(Microsoft.ProjectServer.Client.StatusAssignmentCreationInformation @parameters)
        {
            return AddEx;
        }
        public Microsoft.ProjectServer.Client.StatusAssignment AddEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> Remove(Microsoft.ProjectServer.Client.StatusAssignment @assignment)
        {
            return RemoveEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> RemoveEx { get; set;}

        public override void Update()
        {
        }

        public override void SubmitAllStatusUpdates(System.String @comment)
        {
        }

    }
}

