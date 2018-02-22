
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Workflow
{
    public class WorkflowAssociationMock : WorkflowAssociation
    {


        public override System.Boolean AllowManual => AllowManualEx;
        public System.Boolean AllowManualEx { get; set; }

        public override System.String AssociationData => AssociationDataEx;
        public System.String AssociationDataEx { get; set; }

        public override System.Boolean AutoStartChange => AutoStartChangeEx;
        public System.Boolean AutoStartChangeEx { get; set; }

        public override System.Boolean AutoStartCreate => AutoStartCreateEx;
        public System.Boolean AutoStartCreateEx { get; set; }

        public override System.Guid BaseId => BaseIdEx;
        public System.Guid BaseIdEx { get; set; }

        public override System.DateTime Created => CreatedEx;
        public System.DateTime CreatedEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean Enabled => EnabledEx;
        public System.Boolean EnabledEx { get; set; }

        public override System.String HistoryListTitle => HistoryListTitleEx;
        public System.String HistoryListTitleEx { get; set; }

        public override System.Guid Id => IdEx;
        public System.Guid IdEx { get; set; }

        public override System.String InstantiationUrl => InstantiationUrlEx;
        public System.String InstantiationUrlEx { get; set; }

        public override System.String InternalName => InternalNameEx;
        public System.String InternalNameEx { get; set; }

        public override System.Boolean IsDeclarative => IsDeclarativeEx;
        public System.Boolean IsDeclarativeEx { get; set; }

        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.DateTime Modified => ModifiedEx;
        public System.DateTime ModifiedEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String TaskListTitle => TaskListTitleEx;
        public System.String TaskListTitleEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

        public override void Update()
        {
        }

        public override void DeleteObject()
        {
        }

    }
}

