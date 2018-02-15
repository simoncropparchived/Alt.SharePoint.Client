
namespace Microsoft.SharePoint.Client
{
    public class FieldLinkMock
    {


        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.Boolean Hidden => HiddenEx;
        public System.Boolean HiddenEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Boolean ReadOnly => ReadOnlyEx;
        public System.Boolean ReadOnlyEx { get; set; }

        public override System.Boolean Required => RequiredEx;
        public System.Boolean RequiredEx { get; set; }

        public override System.Boolean ShowInDisplayForm => ShowInDisplayFormEx;
        public System.Boolean ShowInDisplayFormEx { get; set; }

    }
}

