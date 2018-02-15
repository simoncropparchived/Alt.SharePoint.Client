
namespace Microsoft.SharePoint.Client.Publishing
{
    public class CustomizableStringMock : CustomizableString
    {


        public override System.String DefaultValue => DefaultValueEx;
        public System.String DefaultValueEx { get; set; }

        public override System.Boolean UsesDefaultValue => UsesDefaultValueEx;
        public System.Boolean UsesDefaultValueEx { get; set; }

        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

    }
}

