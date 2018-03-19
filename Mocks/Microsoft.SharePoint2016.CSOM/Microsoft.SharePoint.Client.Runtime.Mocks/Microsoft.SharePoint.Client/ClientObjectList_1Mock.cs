
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ClientObjectListMock<T> : ClientObjectList<T> where T : ClientObject
    {


        public override void FromJson(Microsoft.SharePoint.Client.JsonReader @reader)
        {
        }

        public override System.Boolean CustomFromJson(Microsoft.SharePoint.Client.JsonReader @reader)
        {
            return CustomFromJsonEx;
        }
        public System.Boolean CustomFromJsonEx { get; set;}

    }
}

