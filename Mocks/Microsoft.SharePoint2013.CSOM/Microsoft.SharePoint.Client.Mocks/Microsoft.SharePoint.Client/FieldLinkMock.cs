
namespace Microsoft.SharePoint.Client
{
    public class FieldLinkMock : FieldLink
    {


        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Boolean Required => RequiredEx;
        public System.Boolean RequiredEx { get; set; }

    }
}

