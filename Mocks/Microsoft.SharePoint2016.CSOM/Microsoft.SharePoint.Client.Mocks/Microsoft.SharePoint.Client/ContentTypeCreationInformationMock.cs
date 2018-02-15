
namespace Microsoft.SharePoint.Client
{
    public class ContentTypeCreationInformationMock
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String Group => GroupEx;
        public System.String GroupEx { get; set; }

        public override System.String Id => IdEx;
        public System.String IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.SharePoint.Client.ContentType ParentContentType => ParentContentTypeEx;
        public Microsoft.SharePoint.Client.ContentType ParentContentTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

