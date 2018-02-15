
namespace Microsoft.SharePoint.Client.Publishing
{
    public class PageLayoutCreationInformationMock : PageLayoutCreationInformation
    {


        public override System.String AssociatedContentTypeId => AssociatedContentTypeIdEx;
        public System.String AssociatedContentTypeIdEx { get; set; }

        public override System.String MasterPageUrl => MasterPageUrlEx;
        public System.String MasterPageUrlEx { get; set; }

        public override System.String NewPageLayoutEditablePath => NewPageLayoutEditablePathEx;
        public System.String NewPageLayoutEditablePathEx { get; set; }

        public override System.String NewPageLayoutNameWithoutExtension => NewPageLayoutNameWithoutExtensionEx;
        public System.String NewPageLayoutNameWithoutExtensionEx { get; set; }

        public override Microsoft.SharePoint.Client.Web Web => WebEx;
        public Microsoft.SharePoint.Client.Web WebEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

