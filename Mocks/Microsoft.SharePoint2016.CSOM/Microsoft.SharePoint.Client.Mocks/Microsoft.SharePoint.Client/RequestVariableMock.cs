
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RequestVariableMock : RequestVariable
    {


        public override System.String Value => ValueEx;
        public System.String ValueEx { get; set; }

        public override void Append(System.String @value)
        {
        }

        public override void Set(System.String @value)
        {
        }

    }
}

