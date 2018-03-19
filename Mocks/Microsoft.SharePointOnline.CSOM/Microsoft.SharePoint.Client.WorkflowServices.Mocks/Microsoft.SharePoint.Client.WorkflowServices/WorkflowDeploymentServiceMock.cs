
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.WorkflowServices
{
    public class WorkflowDeploymentServiceMock : WorkflowDeploymentService
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetDesignerActions(Microsoft.SharePoint.Client.Web @web)
        {
            return GetDesignerActionsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetDesignerActionsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String, System.String>> GetActivitySignatures(System.DateTime @lastChanged)
        {
            return GetActivitySignaturesEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Collections.Generic.IDictionary<System.String, System.String>> GetActivitySignaturesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Guid> SaveDefinition(Microsoft.SharePoint.Client.WorkflowServices.WorkflowDefinition @definition)
        {
            return SaveDefinitionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Guid> SaveDefinitionEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> ValidateActivity(System.String @activityXaml)
        {
            return ValidateActivityEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> ValidateActivityEx { get; set;}

        public override void PublishDefinition(System.Guid @definitionId)
        {
        }

        public override void DeprecateDefinition(System.Guid @definitionId)
        {
        }

        public override void DeleteDefinition(System.Guid @definitionId)
        {
        }

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowDefinitionCollection EnumerateDefinitions(System.Boolean @publishedOnly)
        {
            return EnumerateDefinitionsEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowDefinitionCollection EnumerateDefinitionsEx { get; set;}

        public override Microsoft.SharePoint.Client.WorkflowServices.WorkflowDefinition GetDefinition(System.Guid @definitionId)
        {
            return GetDefinitionEx;
        }
        public Microsoft.SharePoint.Client.WorkflowServices.WorkflowDefinition GetDefinitionEx { get; set;}

        public override void SaveCollateral(System.Guid @workflowDefinitionId, System.String @leafFileName, System.IO.Stream @fileContent)
        {
        }

        public override void DeleteCollateral(System.Guid @workflowDefinitionId, System.String @leafFileName)
        {
        }

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetCollateralUri(System.Guid @workflowDefinitionId, System.String @leafFileName)
        {
            return GetCollateralUriEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetCollateralUriEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> PackageDefinition(System.Guid @definitionId, System.String @packageDefaultFilename, System.String @packageTitle, System.String @packageDescription)
        {
            return PackageDefinitionEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> PackageDefinitionEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.AppInstance> EnumerateIntegratedApps()
        {
            return EnumerateIntegratedAppsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.AppInstance> EnumerateIntegratedAppsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsIntegratedApp()
        {
            return IsIntegratedAppEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsIntegratedAppEx { get; set;}

    }
}

