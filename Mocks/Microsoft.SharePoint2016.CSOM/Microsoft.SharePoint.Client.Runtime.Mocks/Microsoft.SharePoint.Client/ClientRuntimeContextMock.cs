
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientRuntimeContextMock : ClientRuntimeContext
    {


        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override System.String ApplicationName => ApplicationNameEx;
        public System.String ApplicationNameEx { get; set; }

        public override System.String ClientTag => ClientTagEx;
        public System.String ClientTagEx { get; set; }

        public override System.Boolean DisableReturnValueCache => DisableReturnValueCacheEx;
        public System.Boolean DisableReturnValueCacheEx { get; set; }

        public override System.Boolean ValidateOnClient => ValidateOnClientEx;
        public System.Boolean ValidateOnClientEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientAuthenticationMode AuthenticationMode => AuthenticationModeEx;
        public Microsoft.SharePoint.Client.ClientAuthenticationMode AuthenticationModeEx { get; set; }

        public override Microsoft.SharePoint.Client.FormsAuthenticationLoginInfo FormsAuthenticationLoginInfo => FormsAuthenticationLoginInfoEx;
        public Microsoft.SharePoint.Client.FormsAuthenticationLoginInfo FormsAuthenticationLoginInfoEx { get; set; }

        public override System.Net.ICredentials Credentials => CredentialsEx;
        public System.Net.ICredentials CredentialsEx { get; set; }

        public override Microsoft.SharePoint.Client.WebRequestExecutorFactory WebRequestExecutorFactory => WebRequestExecutorFactoryEx;
        public Microsoft.SharePoint.Client.WebRequestExecutorFactory WebRequestExecutorFactoryEx { get; set; }

        public override Microsoft.SharePoint.Client.ClientRequest PendingRequest => PendingRequestEx;
        public Microsoft.SharePoint.Client.ClientRequest PendingRequestEx { get; set; }

        public override System.Boolean HasPendingRequest => HasPendingRequestEx;
        public System.Boolean HasPendingRequestEx { get; set; }

        public override System.Object Tag => TagEx;
        public System.Object TagEx { get; set; }

        public override System.Int32 RequestTimeout => RequestTimeoutEx;
        public System.Int32 RequestTimeoutEx { get; set; }

        public override System.Collections.Generic.Dictionary<System.String, System.Object> StaticObjects => StaticObjectsEx;
        public System.Collections.Generic.Dictionary<System.String, System.Object> StaticObjectsEx { get; set; }

        public override System.Version ServerSchemaVersion => ServerSchemaVersionEx;
        public System.Version ServerSchemaVersionEx { get; set; }

        public override System.Version ServerLibraryVersion => ServerLibraryVersionEx;
        public System.Version ServerLibraryVersionEx { get; set; }

        public override System.Version RequestSchemaVersion => RequestSchemaVersionEx;
        public System.Version RequestSchemaVersionEx { get; set; }

        public override System.String TraceCorrelationId => TraceCorrelationIdEx;
        public System.String TraceCorrelationIdEx { get; set; }

        public override void ExecuteQuery()
        {
        }

        public override void AddQuery(Microsoft.SharePoint.Client.ClientAction @query)
        {
        }

        public override void AddQueryIdAndResultObject(System.Int64 @id, System.Object @obj)
        {
        }

        public override System.Object ParseObjectFromJsonString(System.String @json)
        {
            return ParseObjectFromJsonStringEx;
        }
        public System.Object ParseObjectFromJsonStringEx { get; set;}

        public override void Dispose()
        {
        }

    }
}

