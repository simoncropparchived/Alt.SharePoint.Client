
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.TenantAdmin.MiddleTier
{
    public class DDIAdapterMock : DDIAdapter
    {


        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetObject(System.String @schema, System.String @workflow, System.IO.Stream @stream)
        {
            return GetObjectEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetObjectEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> SetObject(System.String @schema, System.String @workflow, System.IO.Stream @stream)
        {
            return SetObjectEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> SetObjectEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> NewObject(System.String @schema, System.String @workflow, System.IO.Stream @stream)
        {
            return NewObjectEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> NewObjectEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> GetList(System.String @schema, System.String @workflow, System.IO.Stream @stream)
        {
            return GetListEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> GetListEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> RemoveObjects(System.String @schema, System.String @workflow, System.IO.Stream @stream)
        {
            return RemoveObjectsEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> RemoveObjectsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientResult<System.String> MultiObjectExecute(System.String @schema, System.String @workflow, System.IO.Stream @stream)
        {
            return MultiObjectExecuteEx;
        }
        public Microsoft.SharePoint.Client.ClientResult<System.String> MultiObjectExecuteEx { get; set;}

    }
}

