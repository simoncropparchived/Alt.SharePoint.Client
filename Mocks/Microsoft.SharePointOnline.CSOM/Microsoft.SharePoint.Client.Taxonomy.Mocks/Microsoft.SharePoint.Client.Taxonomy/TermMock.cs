
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermMock : Term
    {


        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Boolean IsDeprecated => IsDeprecatedEx;
        public System.Boolean IsDeprecatedEx { get; set; }

        public override System.Boolean IsKeyword => IsKeywordEx;
        public System.Boolean IsKeywordEx { get; set; }

        public override System.Boolean IsPinned => IsPinnedEx;
        public System.Boolean IsPinnedEx { get; set; }

        public override System.Boolean IsPinnedRoot => IsPinnedRootEx;
        public System.Boolean IsPinnedRootEx { get; set; }

        public override System.Boolean IsReused => IsReusedEx;
        public System.Boolean IsReusedEx { get; set; }

        public override System.Boolean IsRoot => IsRootEx;
        public System.Boolean IsRootEx { get; set; }

        public override System.Boolean IsSourceTerm => IsSourceTermEx;
        public System.Boolean IsSourceTermEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.LabelCollection Labels => LabelsEx;
        public Microsoft.SharePoint.Client.Taxonomy.LabelCollection LabelsEx { get; set; }

        public override System.Collections.Generic.IDictionary<System.String, System.String> LocalCustomProperties => LocalCustomPropertiesEx;
        public System.Collections.Generic.IDictionary<System.String, System.String> LocalCustomPropertiesEx { get; set; }

        public override System.Collections.Generic.IEnumerable<System.Guid> MergedTermIds => MergedTermIdsEx;
        public System.Collections.Generic.IEnumerable<System.Guid> MergedTermIdsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.Term Parent => ParentEx;
        public Microsoft.SharePoint.Client.Taxonomy.Term ParentEx { get; set; }

        public override System.String PathOfTerm => PathOfTermEx;
        public System.String PathOfTermEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet PinSourceTermSet => PinSourceTermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet PinSourceTermSetEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermCollection ReusedTerms => ReusedTermsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermCollection ReusedTermsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.Term SourceTerm => SourceTermEx;
        public Microsoft.SharePoint.Client.Taxonomy.Term SourceTermEx { get; set; }

        public override System.Int32 TermsCount => TermsCountEx;
        public System.Int32 TermsCountEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSet TermSet => TermSetEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSet TermSetEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSets => TermSetsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSetsEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.Term Copy(System.Boolean @doCopyChildren)
        {
            return CopyEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term CopyEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Label CreateLabel(System.String @labelName, System.Int32 @lcid, System.Boolean @isDefault)
        {
            return CreateLabelEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Label CreateLabelEx { get; set;}

        public override void DeleteLocalCustomProperty(System.String @name)
        {
        }

        public override void DeleteAllLocalCustomProperties()
        {
        }

        public override void Deprecate(System.Boolean @doDeprecate)
        {
        }

        public override Microsoft.SharePoint.Client.Taxonomy.LabelCollection GetAllLabels(System.Int32 @lcid)
        {
            return GetAllLabelsEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.LabelCollection GetAllLabelsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultLabel(System.Int32 @lcid)
        {
            return GetDefaultLabelEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultLabelEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetDescription(System.Int32 @lcid)
        {
            return GetDescriptionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetDescriptionEx { get; set;}

        public override Microsoft.SharePoint.Client.Taxonomy.Term Merge(Microsoft.SharePoint.Client.Taxonomy.Term @termToMerge)
        {
            return MergeEx;
        }
        public Microsoft.SharePoint.Client.Taxonomy.Term MergeEx { get; set;}

        public override void Move(Microsoft.SharePoint.Client.Taxonomy.TermSetItem @newParent)
        {
        }

        public override void ReassignSourceTerm(Microsoft.SharePoint.Client.Taxonomy.Term @reusedTerm)
        {
        }

        public override void SetDescription(System.String @description, System.Int32 @lcid)
        {
        }

        public override void SetLocalCustomProperty(System.String @name, System.String @value)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> GetIsDescendantOf(Microsoft.SharePoint.Client.Taxonomy.Term @ancestorTerm)
        {
            return GetIsDescendantOfEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> GetIsDescendantOfEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetPath(System.Int32 @lcid)
        {
            return GetPathEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetPathEx { get; set;}

    }
}

