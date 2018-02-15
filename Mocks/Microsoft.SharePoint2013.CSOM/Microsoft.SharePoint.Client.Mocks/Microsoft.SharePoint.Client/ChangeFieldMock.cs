
namespace Microsoft.SharePoint.Client
{
    public class ChangeFieldMock : ChangeField
    {


        public override System.Guid FieldId => FieldIdEx;
        public System.Guid FieldIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

