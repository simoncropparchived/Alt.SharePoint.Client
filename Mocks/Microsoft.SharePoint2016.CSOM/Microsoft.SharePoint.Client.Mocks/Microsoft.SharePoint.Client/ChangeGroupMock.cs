
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ChangeGroupMock : ChangeGroup
    {


        public override System.Int32 GroupId => GroupIdEx;
        public System.Int32 GroupIdEx { get; set; }

    }
}

