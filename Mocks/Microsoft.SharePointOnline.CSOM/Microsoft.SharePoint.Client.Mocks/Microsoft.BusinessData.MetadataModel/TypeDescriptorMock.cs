
// ReSharper disable IdentifierTypo
namespace Microsoft.BusinessData.MetadataModel
{
    public class TypeDescriptorMock : TypeDescriptor
    {


        public override System.Boolean ContainsReadOnly => ContainsReadOnlyEx;
        public System.Boolean ContainsReadOnlyEx { get; set; }

        public override System.Boolean IsCollection => IsCollectionEx;
        public System.Boolean IsCollectionEx { get; set; }

        public override System.Boolean IsReadOnly => IsReadOnlyEx;
        public System.Boolean IsReadOnlyEx { get; set; }

        public override System.String Name => NameEx;
        public System.String NameEx { get; set; }

        public override System.String TypeName => TypeNameEx;
        public System.String TypeNameEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> ContainsLocalizedDisplayName()
        {
            return ContainsLocalizedDisplayNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> ContainsLocalizedDisplayNameEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetLocalizedDisplayName()
        {
            return GetLocalizedDisplayNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetLocalizedDisplayNameEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultDisplayName()
        {
            return GetDefaultDisplayNameEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetDefaultDisplayNameEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsRoot()
        {
            return IsRootEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsRootEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsLeaf()
        {
            return IsLeafEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.Boolean> IsLeafEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.Collections.TypeDescriptorCollection GetChildTypeDescriptors()
        {
            return GetChildTypeDescriptorsEx;
        }
        public Microsoft.BusinessData.MetadataModel.Collections.TypeDescriptorCollection GetChildTypeDescriptorsEx { get; set;}

        public override Microsoft.BusinessData.MetadataModel.TypeDescriptor GetParentTypeDescriptor()
        {
            return GetParentTypeDescriptorEx;
        }
        public Microsoft.BusinessData.MetadataModel.TypeDescriptor GetParentTypeDescriptorEx { get; set;}

    }
}

