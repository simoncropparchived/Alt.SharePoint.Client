
namespace Microsoft.ProjectServer.Client
{
    public class EntityTypesMock
    {


        public override Microsoft.ProjectServer.Client.EntityType AssignmentEntity => AssignmentEntityEx;
        public Microsoft.ProjectServer.Client.EntityType AssignmentEntityEx { get; set; }

        public override Microsoft.ProjectServer.Client.EntityType ProjectEntity => ProjectEntityEx;
        public Microsoft.ProjectServer.Client.EntityType ProjectEntityEx { get; set; }

        public override Microsoft.ProjectServer.Client.EntityType ResourceEntity => ResourceEntityEx;
        public Microsoft.ProjectServer.Client.EntityType ResourceEntityEx { get; set; }

        public override Microsoft.ProjectServer.Client.EntityType TaskEntity => TaskEntityEx;
        public Microsoft.ProjectServer.Client.EntityType TaskEntityEx { get; set; }

    }
}

