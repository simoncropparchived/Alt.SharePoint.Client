
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class WorkflowSubscriptionMock : WorkflowSubscription
    {


        public override System.Guid DefinitionId => DefinitionIdEx;
        public System.Guid DefinitionIdEx { get; set; }

        public override System.Boolean Enabled => EnabledEx;
        public System.Boolean EnabledEx { get; set; }

        public override System.Guid EventSourceId => EventSourceIdEx;
        public System.Guid EventSourceIdEx { get; set; }

        public override System.Collections.Generic.IList`1<System.String> EventTypes => EventTypesEx;
        public System.Collections.Generic.IList`1<System.String> EventTypesEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.Boolean ManualStartBypassesActivationLimit => ManualStartBypassesActivationLimitEx;
        public System.Boolean ManualStartBypassesActivationLimitEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.String> PropertyDefinitions => PropertyDefinitionsEx;
        public System.Collections.Generic.IDictionary<System.String,System.String> PropertyDefinitionsEx { get; set; }

        public override System.String StatusFieldName => StatusFieldNameEx;
        public System.String StatusFieldNameEx { get; set; }

    }
}

