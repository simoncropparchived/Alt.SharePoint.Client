
namespace Microsoft.BusinessData.MetadataModel
{
    public class EntityFieldMock : EntityField
    {


        public override System.Boolean ContainsLocalizedDisplayName => ContainsLocalizedDisplayNameEx;
        public System.Boolean ContainsLocalizedDisplayNameEx { get; set; }

        public override System.String DefaultDisplayName => DefaultDisplayNameEx;
        public System.String DefaultDisplayNameEx { get; set; }

        public override System.String LocalizedDisplayName => LocalizedDisplayNameEx;
        public System.String LocalizedDisplayNameEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

    }
}

