
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class TaskLinkMock : TaskLink
    {


        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

    }
}

