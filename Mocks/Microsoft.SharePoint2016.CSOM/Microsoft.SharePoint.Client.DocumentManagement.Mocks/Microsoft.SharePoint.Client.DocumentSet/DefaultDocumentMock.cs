
namespace Microsoft.SharePoint.Client.DocumentSet
{
    public class DefaultDocumentMock
    {


        public override Microsoft.SharePoint.Client.ContentTypeId ContentTypeId => ContentTypeIdEx;
        public Microsoft.SharePoint.Client.ContentTypeId ContentTypeIdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

