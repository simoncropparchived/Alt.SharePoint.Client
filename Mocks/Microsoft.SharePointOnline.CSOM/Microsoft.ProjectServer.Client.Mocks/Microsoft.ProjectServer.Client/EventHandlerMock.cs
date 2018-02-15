
namespace Microsoft.ProjectServer.Client
{
    public class EventHandlerMock : EventHandler
    {


        public override System.String AssemblyName => AssemblyNameEx;
        public System.String AssemblyNameEx { get; set; }

        public override System.String ClassName => ClassNameEx;
        public System.String ClassNameEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.String EndpointUrl => EndpointUrlEx;
        public System.String EndpointUrlEx { get; set; }

        public override Microsoft.ProjectServer.Client.Event Event => EventEx;
        public Microsoft.ProjectServer.Client.Event EventEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Int32 Order => OrderEx;
        public System.Int32 OrderEx { get; set; }

    }
}

