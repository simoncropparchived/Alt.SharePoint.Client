
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class VisualizationAppSynchronizationResultMock : VisualizationAppSynchronizationResult
    {


        public override Microsoft.SharePoint.Client.VisualizationAppMappedViewCollection AppMappedViews => AppMappedViewsEx;
        public Microsoft.SharePoint.Client.VisualizationAppMappedViewCollection AppMappedViewsEx { get; set; }

        public override System.String SynchronizationData => SynchronizationDataEx;
        public System.String SynchronizationDataEx { get; set; }

        public override Microsoft.SharePoint.Client.VisualizationAppSynchronizationStatus SynchronizationStatus => SynchronizationStatusEx;
        public Microsoft.SharePoint.Client.VisualizationAppSynchronizationStatus SynchronizationStatusEx { get; set; }

    }
}

