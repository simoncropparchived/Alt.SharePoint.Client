
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ResourceEngagementTimephasedCollectionMock : ResourceEngagementTimephasedCollection
    {


        public override Microsoft.ProjectServer.Client.ResourceEngagementTimephasedPeriod GetByStart(System.DateTime @date)
        {
            return GetByStartEx;
        }
        public Microsoft.ProjectServer.Client.ResourceEngagementTimephasedPeriod GetByStartEx { get; set;}

    }
}

