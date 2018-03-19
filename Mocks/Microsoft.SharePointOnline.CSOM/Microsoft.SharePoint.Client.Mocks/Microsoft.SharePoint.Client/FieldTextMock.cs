
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class FieldTextMock : FieldText
    {


        public override System.Int32 MaxLength => MaxLengthEx;
        public System.Int32 MaxLengthEx { get; set; }

    }
}

