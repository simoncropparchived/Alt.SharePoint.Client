
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class TypeDescriptorMock : TypeDescriptor
    {


        public override System.Object[] Interpretation => InterpretationEx;
        public System.Object[] InterpretationEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.DefaultValue[] DefaultValues => DefaultValuesEx;
        public Microsoft.Office.SharePoint.Tools.DefaultValue[] DefaultValuesEx { get; set; }

        public override Microsoft.Office.SharePoint.Tools.TypeDescriptor[] TypeDescriptors => TypeDescriptorsEx;
        public Microsoft.Office.SharePoint.Tools.TypeDescriptor[] TypeDescriptorsEx { get; set; }

        public override System.String TypeName => TypeNameEx;
        public System.String TypeNameEx { get; set; }

        public override System.String LobName => LobNameEx;
        public System.String LobNameEx { get; set; }

        public override System.String IdentifierEntityNamespace => IdentifierEntityNamespaceEx;
        public System.String IdentifierEntityNamespaceEx { get; set; }

        public override System.String IdentifierEntityName => IdentifierEntityNameEx;
        public System.String IdentifierEntityNameEx { get; set; }

        public override System.String IdentifierName => IdentifierNameEx;
        public System.String IdentifierNameEx { get; set; }

        public override System.String ForeignIdentifierAssociationName => ForeignIdentifierAssociationNameEx;
        public System.String ForeignIdentifierAssociationNameEx { get; set; }

        public override System.String ForeignIdentifierAssociationEntityName => ForeignIdentifierAssociationEntityNameEx;
        public System.String ForeignIdentifierAssociationEntityNameEx { get; set; }

        public override System.String ForeignIdentifierAssociationEntityNamespace => ForeignIdentifierAssociationEntityNamespaceEx;
        public System.String ForeignIdentifierAssociationEntityNamespaceEx { get; set; }

        public override System.String AssociatedFilter => AssociatedFilterEx;
        public System.String AssociatedFilterEx { get; set; }

        public override System.Boolean IsCollection => IsCollectionEx;
        public System.Boolean IsCollectionEx { get; set; }

        public override System.Boolean ReadOnly => ReadOnlyEx;
        public System.Boolean ReadOnlyEx { get; set; }

        public override System.Boolean CreatorField => CreatorFieldEx;
        public System.Boolean CreatorFieldEx { get; set; }

        public override System.Boolean UpdaterField => UpdaterFieldEx;
        public System.Boolean UpdaterFieldEx { get; set; }

        public override System.Boolean PreUpdaterField => PreUpdaterFieldEx;
        public System.Boolean PreUpdaterFieldEx { get; set; }

        public override System.Boolean Significant => SignificantEx;
        public System.Boolean SignificantEx { get; set; }

        public override System.Boolean IsSortInput => IsSortInputEx;
        public System.Boolean IsSortInputEx { get; set; }

    }
}

