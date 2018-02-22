
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class ScriptTypeFactoryMock : ScriptTypeFactory
    {


        public override Microsoft.SharePoint.Client.IFromJson CreateObjectFromScriptType(System.String @scriptType, Microsoft.SharePoint.Client.ClientRuntimeContext @context)
        {
            return CreateObjectFromScriptTypeEx;
        }
        public Microsoft.SharePoint.Client.IFromJson CreateObjectFromScriptTypeEx { get; set;}

    }
}

