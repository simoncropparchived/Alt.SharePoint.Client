
namespace Microsoft.SharePoint.Client
{
    public class FormMock
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath ResourcePath => ResourcePathEx;
        public Microsoft.SharePoint.Client.ResourcePath ResourcePathEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.PageType FormType => FormTypeEx;
        public Microsoft.SharePoint.Client.PageType FormTypeEx { get; set; }

    }
}

