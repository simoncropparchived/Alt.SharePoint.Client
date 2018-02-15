
namespace Microsoft.SharePoint.Client.DocumentSet
{
    public class DocumentSetTemplateMock : DocumentSetTemplate
    {


        public override Microsoft.SharePoint.Client.DocumentSet.AllowedContentTypeCollection AllowedContentTypes => AllowedContentTypesEx;
        public Microsoft.SharePoint.Client.DocumentSet.AllowedContentTypeCollection AllowedContentTypesEx { get; set; }

        public override Microsoft.SharePoint.Client.DocumentSet.DefaultDocumentCollection DefaultDocuments => DefaultDocumentsEx;
        public Microsoft.SharePoint.Client.DocumentSet.DefaultDocumentCollection DefaultDocumentsEx { get; set; }

        public override Microsoft.SharePoint.Client.DocumentSet.SharedFieldCollection SharedFields => SharedFieldsEx;
        public Microsoft.SharePoint.Client.DocumentSet.SharedFieldCollection SharedFieldsEx { get; set; }

        public override Microsoft.SharePoint.Client.DocumentSet.WelcomePageFieldCollection WelcomePageFields => WelcomePageFieldsEx;
        public Microsoft.SharePoint.Client.DocumentSet.WelcomePageFieldCollection WelcomePageFieldsEx { get; set; }

    }
}

