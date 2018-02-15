
namespace Microsoft.SharePoint.Client
{
    public class VisualizationStyleSetMock
    {


        public override System.String AspectRatio => AspectRatioEx;
        public System.String AspectRatioEx { get; set; }

        public override System.String BackgroundColor => BackgroundColorEx;
        public System.String BackgroundColorEx { get; set; }

        public override System.Collections.Generic.IList`1<Microsoft.SharePoint.Client.VisualizationField> Fields => FieldsEx;
        public System.Collections.Generic.IList`1<Microsoft.SharePoint.Client.VisualizationField> FieldsEx { get; set; }

        public override System.String MinHeight => MinHeightEx;
        public System.String MinHeightEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

