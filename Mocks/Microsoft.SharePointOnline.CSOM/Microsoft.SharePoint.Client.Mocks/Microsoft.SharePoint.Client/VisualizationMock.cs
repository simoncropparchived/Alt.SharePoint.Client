
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class VisualizationMock : Visualization
    {


        public override Microsoft.SharePoint.Client.VisualizationStyleSet DefaultScreen => DefaultScreenEx;
        public Microsoft.SharePoint.Client.VisualizationStyleSet DefaultScreenEx { get; set; }

        public override Microsoft.SharePoint.Client.VisualizationStyleSet DetailView => DetailViewEx;
        public Microsoft.SharePoint.Client.VisualizationStyleSet DetailViewEx { get; set; }

        public override Microsoft.SharePoint.Client.VisualizationStyleSet MediumScreen => MediumScreenEx;
        public Microsoft.SharePoint.Client.VisualizationStyleSet MediumScreenEx { get; set; }

        public override Microsoft.SharePoint.Client.VisualizationStyleSet SmallScreen => SmallScreenEx;
        public Microsoft.SharePoint.Client.VisualizationStyleSet SmallScreenEx { get; set; }

        public override Microsoft.SharePoint.Client.VisualizationAppInfo VisualizationAppInfo => VisualizationAppInfoEx;
        public Microsoft.SharePoint.Client.VisualizationAppInfo VisualizationAppInfoEx { get; set; }

        public override Microsoft.SharePoint.Client.VisualizationType VisualizationType => VisualizationTypeEx;
        public Microsoft.SharePoint.Client.VisualizationType VisualizationTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

