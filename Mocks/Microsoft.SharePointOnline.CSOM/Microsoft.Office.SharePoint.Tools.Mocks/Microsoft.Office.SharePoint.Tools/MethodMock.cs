
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class MethodMock : Method
    {


        public override Microsoft.Office.SharePoint.Tools.FilterDescriptor[] FilterDescriptors => FilterDescriptorsEx;
        public Microsoft.Office.SharePoint.Tools.FilterDescriptor[] FilterDescriptorsEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.Parameter[] Parameters => ParametersEx;
        public Microsoft.Office.SharePoint.Tools.Parameter[] ParametersEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.MethodInstance[] MethodInstances => MethodInstancesEx;
        public Microsoft.Office.SharePoint.Tools.MethodInstance[] MethodInstancesEx { get; set; }

        public override System.Boolean IsStatic => IsStaticEx;
        public System.Boolean IsStaticEx { get; set; }

        public override System.String LobName => LobNameEx;
        public System.String LobNameEx { get; set; }

    }
}

