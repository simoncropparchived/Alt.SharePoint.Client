
namespace Microsoft.SharePoint.Client
{
    public class ScriptTypeAttributeMock : ScriptTypeAttribute
    {


        public override System.String ScriptType => ScriptTypeEx;
        public System.String ScriptTypeEx { get; set; }

        public override System.String TypeAlias => TypeAliasEx;
        public System.String TypeAliasEx { get; set; }

        public override System.Boolean ValueObject => ValueObjectEx;
        public System.Boolean ValueObjectEx { get; set; }

        public override System.String ServerTypeId => ServerTypeIdEx;
        public System.String ServerTypeIdEx { get; set; }

    }
}

