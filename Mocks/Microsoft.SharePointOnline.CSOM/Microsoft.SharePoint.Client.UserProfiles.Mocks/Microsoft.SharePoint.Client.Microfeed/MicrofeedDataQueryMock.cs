
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedDataQueryMock : MicrofeedDataQuery
    {


        public override System.UInt32 ItemLimit => ItemLimitEx;
        public System.UInt32 ItemLimitEx { get; set; }

        public override System.String Query => QueryEx;
        public System.String QueryEx { get; set; }

        public override System.String[] ViewFields => ViewFieldsEx;
        public System.String[] ViewFieldsEx { get; set; }

        public override System.Boolean ViewFieldsOnly => ViewFieldsOnlyEx;
        public System.Boolean ViewFieldsOnlyEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

