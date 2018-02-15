
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TaxonomyFieldMock
    {


        public override System.Guid AnchorId => AnchorIdEx;
        public System.Guid AnchorIdEx { get; set; }

        public override System.Boolean CreateValuesInEditForm => CreateValuesInEditFormEx;
        public System.Boolean CreateValuesInEditFormEx { get; set; }

        public override System.Boolean IsAnchorValid => IsAnchorValidEx;
        public System.Boolean IsAnchorValidEx { get; set; }

        public override System.Boolean IsKeyword => IsKeywordEx;
        public System.Boolean IsKeywordEx { get; set; }

        public override System.Boolean IsPathRendered => IsPathRenderedEx;
        public System.Boolean IsPathRenderedEx { get; set; }

        public override System.Boolean IsTermSetValid => IsTermSetValidEx;
        public System.Boolean IsTermSetValidEx { get; set; }

        public override System.Boolean Open => OpenEx;
        public System.Boolean OpenEx { get; set; }

        public override System.Guid SspId => SspIdEx;
        public System.Guid SspIdEx { get; set; }

        public override System.String TargetTemplate => TargetTemplateEx;
        public System.String TargetTemplateEx { get; set; }

        public override System.Guid TermSetId => TermSetIdEx;
        public System.Guid TermSetIdEx { get; set; }

        public override System.Guid TextField => TextFieldEx;
        public System.Guid TextFieldEx { get; set; }

        public override System.Boolean UserCreated => UserCreatedEx;
        public System.Boolean UserCreatedEx { get; set; }

    }
}

