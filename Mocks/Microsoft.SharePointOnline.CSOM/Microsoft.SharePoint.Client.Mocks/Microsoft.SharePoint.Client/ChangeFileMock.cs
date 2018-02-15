
namespace Microsoft.SharePoint.Client
{
    public class ChangeFileMock : ChangeFile
    {


        public override System.Guid UniqueId => UniqueIdEx;
        public System.Guid UniqueIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

