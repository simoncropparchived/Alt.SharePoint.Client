
namespace Microsoft.ProjectServer.Client
{
    public class PageSizesMock
    {


        public override System.Int32 EngagementsTimephased => EngagementsTimephasedEx;
        public System.Int32 EngagementsTimephasedEx { get; set; }

        public override System.Int32 EnterpriseResources => EnterpriseResourcesEx;
        public System.Int32 EnterpriseResourcesEx { get; set; }

        public override System.Int32 Projects => ProjectsEx;
        public System.Int32 ProjectsEx { get; set; }

    }
}

