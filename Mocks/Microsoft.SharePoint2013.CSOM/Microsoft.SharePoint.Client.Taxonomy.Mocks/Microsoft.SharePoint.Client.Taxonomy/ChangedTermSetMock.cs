
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class ChangedTermSetMock : ChangedTermSet
    {


        public override System.Guid FromGroupId => FromGroupIdEx;
        public System.Guid FromGroupIdEx { get; set; }

        public override System.Guid GroupId => GroupIdEx;
        public System.Guid GroupIdEx { get; set; }

    }
}

