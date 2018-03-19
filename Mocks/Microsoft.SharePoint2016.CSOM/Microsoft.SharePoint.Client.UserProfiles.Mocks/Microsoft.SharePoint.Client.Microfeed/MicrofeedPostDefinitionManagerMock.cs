
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedPostDefinitionManagerMock : MicrofeedPostDefinitionManager
    {


        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> GetMicrofeedPostDefinition(System.String @definitionName)
        {
            return GetMicrofeedPostDefinitionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> GetMicrofeedPostDefinitionEx { get; set;}

        public override System.Collections.Generic.IList<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> GetMicrofeedPostDefinitions()
        {
            return GetMicrofeedPostDefinitionsEx;
        }
        public System.Collections.Generic.IList<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> GetMicrofeedPostDefinitionsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> NewMicrofeedPostDefinition(System.String @definitionName)
        {
            return NewMicrofeedPostDefinitionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> NewMicrofeedPostDefinitionEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> UpdateMicrofeedPostDefinition(Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition @postDefinition)
        {
            return UpdateMicrofeedPostDefinitionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition> UpdateMicrofeedPostDefinitionEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteMicrofeedPostDefinition(Microsoft.SharePoint.Client.Microfeed.MicrofeedPostDefinition @postDefinition)
        {
            return DeleteMicrofeedPostDefinitionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> DeleteMicrofeedPostDefinitionEx { get; set;}

    }
}

