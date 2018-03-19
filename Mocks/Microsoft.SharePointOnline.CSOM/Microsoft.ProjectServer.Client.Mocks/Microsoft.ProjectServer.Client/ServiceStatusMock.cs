
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class ServiceStatusMock : ServiceStatus
    {


        public override System.Boolean IsDelegate => IsDelegateEx;
        public System.Boolean IsDelegateEx { get; set; }

        public override System.Boolean IsReadOnly => IsReadOnlyEx;
        public System.Boolean IsReadOnlyEx { get; set; }

        public override void StopDelegation()
        {
        }

    }
}

