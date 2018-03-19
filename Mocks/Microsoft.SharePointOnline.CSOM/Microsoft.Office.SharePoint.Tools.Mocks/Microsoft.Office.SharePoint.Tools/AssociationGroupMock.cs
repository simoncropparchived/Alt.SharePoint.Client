
// ReSharper disable IdentifierTypo
namespace Microsoft.Office.SharePoint.Tools
{
    public class AssociationGroupMock : AssociationGroup
    {


        public override Microsoft.Office.SharePoint.Tools.AssociationReference[] AssociationReference => AssociationReferenceEx;
        public Microsoft.Office.SharePoint.Tools.AssociationReference[] AssociationReferenceEx { get; set; }

    }
}

