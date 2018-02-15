
namespace Microsoft.ProjectServer.Client
{
    public class EngagementSaveConflictExceptionMock : EngagementSaveConflictException
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

