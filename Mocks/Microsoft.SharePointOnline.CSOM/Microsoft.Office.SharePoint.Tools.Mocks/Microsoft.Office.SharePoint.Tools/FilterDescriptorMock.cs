
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class FilterDescriptorMock : FilterDescriptor
    {


        public override Microsoft.Office.SharePoint.Tools.FilterDescriptorType Type => TypeEx;
        public Microsoft.Office.SharePoint.Tools.FilterDescriptorType TypeEx { get; set; }

        public override System.String FilterField => FilterFieldEx;
        public System.String FilterFieldEx { get; set; }

    }
}

