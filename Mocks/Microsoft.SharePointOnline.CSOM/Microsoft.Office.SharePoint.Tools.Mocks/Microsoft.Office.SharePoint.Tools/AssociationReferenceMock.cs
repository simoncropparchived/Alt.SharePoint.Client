
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class AssociationReferenceMock : AssociationReference
    {


        public override System.String EntityNamespace => EntityNamespaceEx;
        public System.String EntityNamespaceEx { get; set; }

        public override System.String EntityName => EntityNameEx;
        public System.String EntityNameEx { get; set; }

        public override System.String AssociationName => AssociationNameEx;
        public System.String AssociationNameEx { get; set; }

        public override System.Boolean Reverse => ReverseEx;
        public System.Boolean ReverseEx { get; set; }

    }
}

