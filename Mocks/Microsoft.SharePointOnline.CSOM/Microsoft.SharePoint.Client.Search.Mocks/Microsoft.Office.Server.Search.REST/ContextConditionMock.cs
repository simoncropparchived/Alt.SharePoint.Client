
namespace Microsoft.Office.Server.Search.REST
{
    public class ContextConditionMock
    {


        public override System.String ContextConditionType => ContextConditionTypeEx;
        public System.String ContextConditionTypeEx { get; set; }

        public override System.Guid SourceId => SourceIdEx;
        public System.Guid SourceIdEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

