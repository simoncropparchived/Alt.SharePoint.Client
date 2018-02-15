
namespace Microsoft.Office.SharePoint.Tools
{
    public class EntityMock : Entity
    {


        public override Microsoft.Office.SharePoint.Tools.Identifier[] Identifiers => IdentifiersEx;
        public Microsoft.Office.SharePoint.Tools.Identifier[] IdentifiersEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.Method[] Methods => MethodsEx;
        public Microsoft.Office.SharePoint.Tools.Method[] MethodsEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.AssociationGroup[] AssociationGroups => AssociationGroupsEx;
        public Microsoft.Office.SharePoint.Tools.AssociationGroup[] AssociationGroupsEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.Action[] Actions => ActionsEx;
        public Microsoft.Office.SharePoint.Tools.Action[] ActionsEx { get; set; }

        public override System.String Namespace => NamespaceEx;
        public System.String NamespaceEx { get; set; }

        public override System.String Version => VersionEx;
        public System.String VersionEx { get; set; }

        public override System.String EstimatedInstanceCount => EstimatedInstanceCountEx;
        public System.String EstimatedInstanceCountEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.OperationModeType DefaultOperationMode => DefaultOperationModeEx;
        public Microsoft.Office.SharePoint.Tools.OperationModeType DefaultOperationModeEx { get; set; }

    }
}

