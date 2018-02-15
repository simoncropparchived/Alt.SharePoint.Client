
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class PopularQueryMock
    {


        public override System.Int32 ClickCount => ClickCountEx;
        public System.Int32 ClickCountEx { get; set; }

        public override System.Int32 LCID => LCIDEx;
        public System.Int32 LCIDEx { get; set; }

        public override System.Int32 QueryCount => QueryCountEx;
        public System.Int32 QueryCountEx { get; set; }

        public override System.String QueryText => QueryTextEx;
        public System.String QueryTextEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

