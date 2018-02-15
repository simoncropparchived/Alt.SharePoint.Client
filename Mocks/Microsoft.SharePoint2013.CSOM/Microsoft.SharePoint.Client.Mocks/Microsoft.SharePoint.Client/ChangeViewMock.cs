
namespace Microsoft.SharePoint.Client
{
    public class ChangeViewMock
    {


        public override System.Guid ViewId => ViewIdEx;
        public System.Guid ViewIdEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

