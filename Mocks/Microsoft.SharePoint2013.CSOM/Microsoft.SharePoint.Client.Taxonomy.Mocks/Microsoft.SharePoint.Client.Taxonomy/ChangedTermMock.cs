
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class ChangedTermMock
    {


        public override System.Collections.Generic.IEnumerable`1<System.String> ChangedCustomProperties => ChangedCustomPropertiesEx;
        public System.Collections.Generic.IEnumerable`1<System.String> ChangedCustomPropertiesEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> ChangedLocalCustomProperties => ChangedLocalCustomPropertiesEx;
        public System.Collections.Generic.IEnumerable`1<System.String> ChangedLocalCustomPropertiesEx { get; set; }

        public override System.Guid GroupId => GroupIdEx;
        public System.Guid GroupIdEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.Int32> LcidsForChangedDescriptions => LcidsForChangedDescriptionsEx;
        public System.Collections.Generic.IEnumerable`1<System.Int32> LcidsForChangedDescriptionsEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.Int32> LcidsForChangedLabels => LcidsForChangedLabelsEx;
        public System.Collections.Generic.IEnumerable`1<System.Int32> LcidsForChangedLabelsEx { get; set; }

        public override System.Guid TermSetId => TermSetIdEx;
        public System.Guid TermSetIdEx { get; set; }

    }
}

