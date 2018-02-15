
namespace Microsoft.Office.SharePoint.Tools
{
    public class ActionMock
    {


        public override Microsoft.Office.SharePoint.Tools.ActionParameter[] ActionParameters => ActionParametersEx;
        public Microsoft.Office.SharePoint.Tools.ActionParameter[] ActionParametersEx { get; set; }

        public override System.String Position => PositionEx;
        public System.String PositionEx { get; set; }

        public override System.Boolean IsOpenedInNewWindow => IsOpenedInNewWindowEx;
        public System.Boolean IsOpenedInNewWindowEx { get; set; }

        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String ImageUrl => ImageUrlEx;
        public System.String ImageUrlEx { get; set; }

    }
}

