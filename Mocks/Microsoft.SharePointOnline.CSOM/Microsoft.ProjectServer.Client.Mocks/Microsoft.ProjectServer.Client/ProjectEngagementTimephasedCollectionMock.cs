
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ProjectEngagementTimephasedCollectionMock : ProjectEngagementTimephasedCollection
    {


        public override Microsoft.ProjectServer.Client.ProjectEngagementTimephasedPeriod GetByStart(System.DateTime @date)
        {
            return GetByStartEx;
        }
        public Microsoft.ProjectServer.Client.ProjectEngagementTimephasedPeriod GetByStartEx { get; set;}

    }
}

