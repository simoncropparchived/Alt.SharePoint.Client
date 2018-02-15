
namespace Microsoft.ProjectServer.Client
{
    public class StageDetailPageMock : StageDetailPage
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override Microsoft.ProjectServer.Client.ProjectDetailPage Page => PageEx;
        public Microsoft.ProjectServer.Client.ProjectDetailPage PageEx { get; set; }

        public override System.Int32 Position => PositionEx;
        public System.Int32 PositionEx { get; set; }

        public override System.Boolean RequiresAttention => RequiresAttentionEx;
        public System.Boolean RequiresAttentionEx { get; set; }

        public override Microsoft.ProjectServer.Client.Stage Stage => StageEx;
        public Microsoft.ProjectServer.Client.Stage StageEx { get; set; }

    }
}

