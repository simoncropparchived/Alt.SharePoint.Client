
namespace Microsoft.SharePoint.Client
{
    public class ChangeItemMock
    {


        public override System.String Editor => EditorEx;
        public System.String EditorEx { get; set; }

        public override System.Int32 ItemId => ItemIdEx;
        public System.Int32 ItemIdEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.String ServerRelativeUrl => ServerRelativeUrlEx;
        public System.String ServerRelativeUrlEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

