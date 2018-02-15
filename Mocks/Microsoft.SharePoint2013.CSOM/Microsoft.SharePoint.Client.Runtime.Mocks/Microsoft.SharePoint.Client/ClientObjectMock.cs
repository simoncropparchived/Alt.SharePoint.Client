
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectMock
    {


        public override Microsoft.SharePoint.Client.ClientRuntimeContext Context => ContextEx;
        public Microsoft.SharePoint.Client.ClientRuntimeContext ContextEx { get; set; }

        public override System.Object Tag => TagEx;
        public System.Object TagEx { get; set; }

        public override Microsoft.SharePoint.Client.ObjectPath Path => PathEx;
        public Microsoft.SharePoint.Client.ObjectPath PathEx { get; set; }

        public override System.String ObjectVersion => ObjectVersionEx;
        public System.String ObjectVersionEx { get; set; }

        public override System.Nullable`1<System.Boolean> ServerObjectIsNull => ServerObjectIsNullEx;
        public System.Nullable`1<System.Boolean> ServerObjectIsNullEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientObject TypedObject => TypedObjectEx;
        public Microsoft.SharePoint.Client.ClientObject TypedObjectEx { get; set; }

    }
}

