
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermGroupMock : TermGroup
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean IsSiteCollectionGroup => IsSiteCollectionGroupEx;
        public System.Boolean IsSiteCollectionGroupEx { get; set; }

        public override System.Boolean IsSystemGroup => IsSystemGroupEx;
        public System.Boolean IsSystemGroupEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSets => TermSetsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSetsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet CreateTermSet(System.String @name, System.Guid @newTermSetId, System.Int32 @lcid)
        {
            return CreateTermSetEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSet CreateTermSetEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ExportObject()
        {
            return ExportObjectEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ExportObjectEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.ChangedItemCollection GetChanges(Microsoft.SharePoint.Client.Taxonomy.ChangeInformation @changeInformation)
        {
            return GetChangesEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.ChangedItemCollection GetChangesEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsWithCustomProperty(Microsoft.SharePoint.Client.Taxonomy.CustomPropertyMatchInformation @customPropertyMatchInformation)
        {
            return GetTermSetsWithCustomPropertyEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection GetTermSetsWithCustomPropertyEx { get; set;}

    }
}

