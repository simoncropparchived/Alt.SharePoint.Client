
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client.CompliancePolicy
{
    public class SPPolicyStoreMock : SPPolicyStore
    {


        public override Microsoft.SharePoint.Client.CompliancePolicy.SPSyncNotificationEndpointInfo NotifyUnifiedPolicySyncForLogicalWorkload(System.String @notificationId, System.String @syncSvcUrl, System.String[] @changeInfos, System.Boolean @syncNow, System.Boolean @fullSyncForTenant, System.Int32 @workload)
        {
            return NotifyUnifiedPolicySyncForLogicalWorkloadEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPSyncNotificationEndpointInfo NotifyUnifiedPolicySyncForLogicalWorkloadEx { get; set;}

        public override Microsoft.SharePoint.Client.CompliancePolicy.SPScsTenantEndPointInfo GetSPScsTenantEndPointInfo(System.String @eopCorrelationId)
        {
            return GetSPScsTenantEndPointInfoEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPScsTenantEndPointInfo GetSPScsTenantEndPointInfoEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> NotifyUnifiedFileSyncForSPTenant(System.Int32 @syncFileType, System.Guid @notificationId)
        {
            return NotifyUnifiedFileSyncForSPTenantEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> NotifyUnifiedFileSyncForSPTenantEx { get; set;}

        public override void UpdatePolicyAssociation(Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyAssociation @policyAssociation)
        {
        }

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyAssociation> GetPolicyAssociations(System.Int32 @scenario, System.Int32 @workload)
        {
            return GetPolicyAssociationsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyAssociation> GetPolicyAssociationsEx { get; set;}

        public override Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyAssociation GetPolicyAssociation(System.Guid @policyAssociationId)
        {
            return GetPolicyAssociationEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyAssociation GetPolicyAssociationEx { get; set;}

        public override Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyAssociation GetPolicyAssociationForContainer(System.String @containerId)
        {
            return GetPolicyAssociationForContainerEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyAssociation GetPolicyAssociationForContainerEx { get; set;}

        public override void DeletePolicyAssociation(System.Guid @policyAssociationId)
        {
        }

        public override Microsoft.SharePoint.Client.List GetPolicyEventList()
        {
            return GetPolicyEventListEx;
        }
        public Microsoft.SharePoint.Client.List GetPolicyEventListEx { get; set;}

        public override void UpdatePolicyEvent(Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyEvent @policyEvent)
        {
        }

        public override Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyEvent GetPolicyEvent(System.Guid @id)
        {
            return GetPolicyEventEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyEvent GetPolicyEventEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyEvent> GetPolicyEvents(System.DateTime @startDate, System.DateTime @endDate)
        {
            return GetPolicyEventsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyEvent> GetPolicyEventsEx { get; set;}

        public override void UpdatePolicyRule(Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyRule @policyRule)
        {
        }

        public override Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyRule GetPolicyRule(System.Guid @policyRuleId, System.Boolean @throwIfNull)
        {
            return GetPolicyRuleEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyRule GetPolicyRuleEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyRule> GetPolicyRules(System.Guid @policyDefinitionId)
        {
            return GetPolicyRulesEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyRule> GetPolicyRulesEx { get; set;}

        public override void DeletePolicyRule(System.Guid @policyRuleId)
        {
        }

        public override void UpdatePolicyDefinition(Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyDefinition @policyDefinition)
        {
        }

        public override Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyDefinition GetPolicyDefinition(System.Guid @policyDefinitionId)
        {
            return GetPolicyDefinitionEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyDefinition GetPolicyDefinitionEx { get; set;}

        public override void DeletePolicyDefinition(System.Guid @policyDefinitionId)
        {
        }

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyBinding> GetPolicyBindings(System.Int32 @workload)
        {
            return GetPolicyBindingsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyBinding> GetPolicyBindingsEx { get; set;}

        public override System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.CompliancePolicy.ComplianceTag> GetComplianceTags()
        {
            return GetComplianceTagsEx;
        }
        public System.Collections.Generic.IEnumerable<Microsoft.SharePoint.Client.CompliancePolicy.ComplianceTag> GetComplianceTagsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyDefinition> GetPolicyDefinitions(System.Int32 @scenario)
        {
            return GetPolicyDefinitionsEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyDefinition> GetPolicyDefinitionsEx { get; set;}

        public override void UpdatePolicyBinding(Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyBinding @policyBinding)
        {
        }

        public override Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyBinding GetPolicyBinding(System.Guid @policyBindingId)
        {
            return GetPolicyBindingEx;
        }
        public Microsoft.SharePoint.Client.CompliancePolicy.SPPolicyBinding GetPolicyBindingEx { get; set;}

        public override void DeletePolicyBinding(System.Guid @policyBindingId)
        {
        }

    }
}

