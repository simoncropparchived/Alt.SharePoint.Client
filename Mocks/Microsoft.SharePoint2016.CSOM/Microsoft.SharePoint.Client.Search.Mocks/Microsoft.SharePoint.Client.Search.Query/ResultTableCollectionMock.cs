
namespace Microsoft.SharePoint.Client.Search.Query
{
    public class ResultTableCollectionMock : ResultTableCollection
    {


        public override System.Int32 ElapsedTime => ElapsedTimeEx;
        public System.Int32 ElapsedTimeEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,System.Object> Properties => PropertiesEx;
        public System.Collections.Generic.IDictionary<System.String,System.Object> PropertiesEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String,Microsoft.Office.Server.Search.WebControls.ControlMessage> QueryErrors => QueryErrorsEx;
        public System.Collections.Generic.IDictionary<System.String,Microsoft.Office.Server.Search.WebControls.ControlMessage> QueryErrorsEx { get; set; }

        public override System.String QueryId => QueryIdEx;
        public System.String QueryIdEx { get; set; }

        public override System.String SpellingSuggestion => SpellingSuggestionEx;
        public System.String SpellingSuggestionEx { get; set; }

        public override System.Collections.Generic.IList<System.Guid> TriggeredRules => TriggeredRulesEx;
        public System.Collections.Generic.IList<System.Guid> TriggeredRulesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

