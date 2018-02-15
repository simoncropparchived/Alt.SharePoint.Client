
namespace Microsoft.SharePoint.Client
{
    public class ChangeContentTypeMock : ChangeContentType
    {


        public override Microsoft.SharePoint.Client.ContentTypeId ContentTypeId => ContentTypeIdEx;
        public Microsoft.SharePoint.Client.ContentTypeId ContentTypeIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

