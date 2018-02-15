
namespace Microsoft.SharePoint.Client
{
    public class RenderListDataParametersMock : RenderListDataParameters
    {


        public override System.String FolderServerRelativeUrl => FolderServerRelativeUrlEx;
        public System.String FolderServerRelativeUrlEx { get; set; }

        public override System.String Paging => PagingEx;
        public System.String PagingEx { get; set; }

        public override Microsoft.SharePoint.Client.RenderListDataOptions RenderOptions => RenderOptionsEx;
        public Microsoft.SharePoint.Client.RenderListDataOptions RenderOptionsEx { get; set; }

        public override System.String ViewXml => ViewXmlEx;
        public System.String ViewXmlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

