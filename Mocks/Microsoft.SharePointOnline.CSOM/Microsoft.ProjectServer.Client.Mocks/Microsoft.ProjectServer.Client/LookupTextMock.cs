
namespace Microsoft.ProjectServer.Client
{
    public class LookupTextMock : LookupText
    {


        public override System.Boolean HasChildren => HasChildrenEx;
        public System.Boolean HasChildrenEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupMask Mask => MaskEx;
        public Microsoft.ProjectServer.Client.LookupMask MaskEx { get; set; }

        public override Microsoft.ProjectServer.Client.LookupText Parent => ParentEx;
        public Microsoft.ProjectServer.Client.LookupText ParentEx { get; set; }

        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

    }
}

