
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FlowSynchronizationResultMock : FlowSynchronizationResult
    {


        public override System.String SynchronizationData => SynchronizationDataEx;
        public System.String SynchronizationDataEx { get; set; }

        public override Microsoft.SharePoint.Client.FlowSynchronizationStatus SynchronizationStatus => SynchronizationStatusEx;
        public Microsoft.SharePoint.Client.FlowSynchronizationStatus SynchronizationStatusEx { get; set; }

    }
}

