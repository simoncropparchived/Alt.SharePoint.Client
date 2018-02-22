
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class PhaseMock : Phase
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override Microsoft.ProjectServer.Client.StageCollection Stages => StagesEx;
        public Microsoft.ProjectServer.Client.StageCollection StagesEx { get; set; }

        public override void DeleteObject()
        {
        }

    }
}

