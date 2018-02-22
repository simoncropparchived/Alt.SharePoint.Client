
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class ActionParameterMock : ActionParameter
    {


        public override System.String Index => IndexEx;
        public System.String IndexEx { get; set; }

    }
}

