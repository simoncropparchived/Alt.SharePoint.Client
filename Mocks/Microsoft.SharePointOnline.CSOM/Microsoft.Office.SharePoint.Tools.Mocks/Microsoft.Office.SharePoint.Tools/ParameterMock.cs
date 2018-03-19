
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class ParameterMock : Parameter
    {


        public override Microsoft.Office.SharePoint.Tools.TypeDescriptor TypeDescriptor => TypeDescriptorEx;
        public Microsoft.Office.SharePoint.Tools.TypeDescriptor TypeDescriptorEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.ParameterDirection Direction => DirectionEx;
        public Microsoft.Office.SharePoint.Tools.ParameterDirection DirectionEx { get; set; }

    }
}

