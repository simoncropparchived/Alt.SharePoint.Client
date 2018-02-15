
namespace Microsoft.ProjectServer.Client
{
    public class StageCustomFieldMock
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Boolean ReadOnly => ReadOnlyEx;
        public System.Boolean ReadOnlyEx { get; set; }

        public override System.Boolean Required => RequiredEx;
        public System.Boolean RequiredEx { get; set; }

        public override Microsoft.ProjectServer.Client.Stage Stage => StageEx;
        public Microsoft.ProjectServer.Client.Stage StageEx { get; set; }

    }
}

