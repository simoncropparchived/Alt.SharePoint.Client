
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RequestResourcesMock : RequestResources
    {


        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.Boolean UserInformationList => UserInformationListEx;
        public System.Boolean UserInformationListEx { get; set; }

        public override System.Boolean WebProperties => WebPropertiesEx;
        public System.Boolean WebPropertiesEx { get; set; }

        public override System.Boolean Features => FeaturesEx;
        public System.Boolean FeaturesEx { get; set; }

        public override System.Boolean NavigationStructure => NavigationStructureEx;
        public System.Boolean NavigationStructureEx { get; set; }

        public override System.Guid ViewId => ViewIdEx;
        public System.Guid ViewIdEx { get; set; }

    }
}

