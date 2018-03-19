
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.Runtime
{
    public class EntityIdentityMock : EntityIdentity
    {


        public override System.Collections.Generic.Dictionary<System.String, System.Object> FieldValues => FieldValuesEx;
        public System.Collections.Generic.Dictionary<System.String, System.Object> FieldValuesEx { get; set; }

        public override System.Object this[System.String fieldName] => ItemEx[fieldName];
        public System.Collections.Generic.Dictionary<System.String, System.Object> ItemEx { get; set; }


        public override System.Int32 IdentifierCount => IdentifierCountEx;
        public System.Int32 IdentifierCountEx { get; set; }

        public override void RefreshLoad()
        {
        }

    }
}

