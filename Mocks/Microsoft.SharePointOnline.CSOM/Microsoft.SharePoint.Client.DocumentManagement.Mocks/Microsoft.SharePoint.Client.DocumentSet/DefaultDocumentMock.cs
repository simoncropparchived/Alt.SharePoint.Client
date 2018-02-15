
namespace Microsoft.SharePoint.Client.DocumentSet
{
    public class DefaultDocumentMock : DefaultDocument
    {


        public override Microsoft.SharePoint.Client.ContentTypeId ContentTypeId => ContentTypeIdEx;
        public Microsoft.SharePoint.Client.ContentTypeId ContentTypeIdEx { get; set; }

        public override Microsoft.SharePoint.Client.ResourcePath DocumentPath => DocumentPathEx;
        public Microsoft.SharePoint.Client.ResourcePath DocumentPathEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

