
namespace Microsoft.ProjectServer.Client
{
    public class ServiceStatusMock
    {


        public override System.Boolean IsDelegate => IsDelegateEx;
        public System.Boolean IsDelegateEx { get; set; }

        public override System.Boolean IsReadOnly => IsReadOnlyEx;
        public System.Boolean IsReadOnlyEx { get; set; }

    }
}

