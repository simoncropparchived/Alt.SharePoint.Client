
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PlanAssignmentIntervalCollectionMock : PlanAssignmentIntervalCollection
    {


        public override Microsoft.ProjectServer.Client.PlanAssignmentInterval GetById(System.String @id)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.PlanAssignmentInterval GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.PlanAssignmentInterval GetByStart(System.DateTime @start)
        {
            return GetByStartEx;
        }
        public Microsoft.ProjectServer.Client.PlanAssignmentInterval GetByStartEx { get; set;}

    }
}

