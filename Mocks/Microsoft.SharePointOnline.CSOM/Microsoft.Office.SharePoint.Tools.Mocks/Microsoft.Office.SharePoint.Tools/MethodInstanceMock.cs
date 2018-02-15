
namespace Microsoft.Office.SharePoint.Tools
{
    public class MethodInstanceMock : MethodInstance
    {


        public override Microsoft.Office.SharePoint.Tools.MethodInstanceType Type => TypeEx;
        public Microsoft.Office.SharePoint.Tools.MethodInstanceType TypeEx { get; set; }

        public override System.Boolean Default => DefaultEx;
        public System.Boolean DefaultEx { get; set; }

        public override System.String ReturnParameterName => ReturnParameterNameEx;
        public System.String ReturnParameterNameEx { get; set; }

        public override System.String ReturnTypeDescriptorName => ReturnTypeDescriptorNameEx;
        public System.String ReturnTypeDescriptorNameEx { get; set; }

        public override System.String ReturnTypeDescriptorLevel => ReturnTypeDescriptorLevelEx;
        public System.String ReturnTypeDescriptorLevelEx { get; set; }

        public override System.String ReturnTypeDescriptorPath => ReturnTypeDescriptorPathEx;
        public System.String ReturnTypeDescriptorPathEx { get; set; }

    }
}

