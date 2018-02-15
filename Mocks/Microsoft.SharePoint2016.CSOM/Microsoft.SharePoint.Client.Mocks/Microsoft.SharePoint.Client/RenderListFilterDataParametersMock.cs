
namespace Microsoft.SharePoint.Client
{
    public class RenderListFilterDataParametersMock : RenderListFilterDataParameters
    {


        public override System.String FieldInternalName => FieldInternalNameEx;
        public System.String FieldInternalNameEx { get; set; }

        public override System.String OverrideScope => OverrideScopeEx;
        public System.String OverrideScopeEx { get; set; }

        public override System.String ProcessQStringToCAML => ProcessQStringToCAMLEx;
        public System.String ProcessQStringToCAMLEx { get; set; }

        public override System.String ViewId => ViewIdEx;
        public System.String ViewIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

