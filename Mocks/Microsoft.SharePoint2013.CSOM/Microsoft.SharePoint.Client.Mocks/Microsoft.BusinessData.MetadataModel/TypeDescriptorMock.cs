
namespace Microsoft.BusinessData.MetadataModel
{
    public class TypeDescriptorMock : TypeDescriptor
    {


        public override System.Boolean ContainsReadOnly => ContainsReadOnlyEx;
        public System.Boolean ContainsReadOnlyEx { get; set; }

        public override System.Boolean IsCollection => IsCollectionEx;
        public System.Boolean IsCollectionEx { get; set; }

        public override System.Boolean IsReadOnly => IsReadOnlyEx;
        public System.Boolean IsReadOnlyEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String TypeName => TypeNameEx;
        public System.String TypeNameEx { get; set; }

    }
}

