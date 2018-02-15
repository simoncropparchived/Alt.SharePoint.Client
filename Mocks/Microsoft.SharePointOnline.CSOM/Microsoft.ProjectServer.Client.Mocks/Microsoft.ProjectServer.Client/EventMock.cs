
namespace Microsoft.ProjectServer.Client
{
    public class EventMock : Event
    {


        public override System.String EventName => EventNameEx;
        public System.String EventNameEx { get; set; }

        public override System.Int32 Id => IdEx;
        public System.Int32 IdEx { get; set; }

        public override System.String SourceName => SourceNameEx;
        public System.String SourceNameEx { get; set; }

    }
}

