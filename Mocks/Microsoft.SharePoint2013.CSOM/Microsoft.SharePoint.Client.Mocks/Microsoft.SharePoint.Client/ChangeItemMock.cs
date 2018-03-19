
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ChangeItemMock : ChangeItem
    {


        public override System.Int32 ItemId => ItemIdEx;
        public System.Int32 ItemIdEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

