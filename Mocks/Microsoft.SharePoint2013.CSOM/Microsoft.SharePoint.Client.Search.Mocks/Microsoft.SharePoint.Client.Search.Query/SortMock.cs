
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class SortMock
    {


        public override Microsoft.SharePoint.Client.Search.Query.SortDirection Direction => DirectionEx;
        public Microsoft.SharePoint.Client.Search.Query.SortDirection DirectionEx { get; set; }

        public override System.String Property => PropertyEx;
        public System.String PropertyEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

