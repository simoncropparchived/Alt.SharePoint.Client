
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class StatusAssignmentHistoryLineCollectionMock : StatusAssignmentHistoryLineCollection
    {


        public override Microsoft.ProjectServer.Client.StatusAssignmentHistoryLine GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.StatusAssignmentHistoryLine GetByIdEx { get; set;}

    }
}

