
namespace Microsoft.BusinessData.MetadataModel
{
    public class EntityViewMock : EntityView
    {


        public override Microsoft.BusinessData.MetadataModel.Collections.EntityFieldCollection Fields => FieldsEx;
        public Microsoft.BusinessData.MetadataModel.Collections.EntityFieldCollection FieldsEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String RelatedSpecificFinderName => RelatedSpecificFinderNameEx;
        public System.String RelatedSpecificFinderNameEx { get; set; }

    }
}

