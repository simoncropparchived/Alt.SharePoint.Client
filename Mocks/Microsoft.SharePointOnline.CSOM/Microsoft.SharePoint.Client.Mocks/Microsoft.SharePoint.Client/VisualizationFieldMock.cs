
namespace Microsoft.SharePoint.Client
{
    public class VisualizationFieldMock : VisualizationField
    {


        public override System.String InternalName => InternalNameEx;
        public System.String InternalNameEx { get; set; }

        public override System.String Style => StyleEx;
        public System.String StyleEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

