
namespace Microsoft.SharePoint.Client
{
    public class AppPropertiesMock
    {


        public override System.Boolean AppSettingsEnabled => AppSettingsEnabledEx;
        public System.Boolean AppSettingsEnabledEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String EulaUrl => EulaUrlEx;
        public System.String EulaUrlEx { get; set; }

        public override System.Boolean IsAnonymous => IsAnonymousEx;
        public System.Boolean IsAnonymousEx { get; set; }

        public override System.Boolean IsDisabled => IsDisabledEx;
        public System.Boolean IsDisabledEx { get; set; }

        public override System.Boolean ManagedDeploymentEnabled => ManagedDeploymentEnabledEx;
        public System.Boolean ManagedDeploymentEnabledEx { get; set; }

        public override System.Boolean ManagePermissionsEnabled => ManagePermissionsEnabledEx;
        public System.Boolean ManagePermissionsEnabledEx { get; set; }

        public override System.Boolean ManageSeatsEnabled => ManageSeatsEnabledEx;
        public System.Boolean ManageSeatsEnabledEx { get; set; }

        public override System.Boolean MonitoringEnabled => MonitoringEnabledEx;
        public System.Boolean MonitoringEnabledEx { get; set; }

        public override System.String Publisher => PublisherEx;
        public System.String PublisherEx { get; set; }

        public override System.Boolean RemoveEnabled => RemoveEnabledEx;
        public System.Boolean RemoveEnabledEx { get; set; }

        public override System.Boolean SideLoadEnabled => SideLoadEnabledEx;
        public System.Boolean SideLoadEnabledEx { get; set; }

        public override System.String SupportUrl => SupportUrlEx;
        public System.String SupportUrlEx { get; set; }

        public override System.Boolean ViewInMarketPlaceEnabled => ViewInMarketPlaceEnabledEx;
        public System.Boolean ViewInMarketPlaceEnabledEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

