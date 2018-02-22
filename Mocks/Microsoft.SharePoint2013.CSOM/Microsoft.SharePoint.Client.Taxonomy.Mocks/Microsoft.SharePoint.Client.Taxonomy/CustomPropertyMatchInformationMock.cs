
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class CustomPropertyMatchInformationMock : CustomPropertyMatchInformation
    {


        public override System.String CustomPropertyName => CustomPropertyNameEx;
        public System.String CustomPropertyNameEx { get; set; }

        public override System.String CustomPropertyValue => CustomPropertyValueEx;
        public System.String CustomPropertyValueEx { get; set; }

        public override System.Int32 ResultCollectionSize => ResultCollectionSizeEx;
        public System.Int32 ResultCollectionSizeEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.StringMatchOption StringMatchOption => StringMatchOptionEx;
        public Microsoft.SharePoint.Client.Taxonomy.StringMatchOption StringMatchOptionEx { get; set; }

        public override System.Boolean TrimUnavailable => TrimUnavailableEx;
        public System.Boolean TrimUnavailableEx { get; set; }

    }
}

