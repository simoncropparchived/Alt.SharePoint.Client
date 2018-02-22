
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class LookupDateMock : LookupDate
    {


        public override System.DateTime Value => ValueEx;
        public System.DateTime ValueEx { get; set; }

    }
}

