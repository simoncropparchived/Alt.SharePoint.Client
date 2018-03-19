
// ReSharper disable IdentifierTypo
namespace Microsoft.ProjectServer.Client
{
    public class EventCollectionMock : EventCollection
    {


        public override Microsoft.ProjectServer.Client.Event GetById(System.String @objectId)
        {
            return GetByIdEx;
        }
        public Microsoft.ProjectServer.Client.Event GetByIdEx { get; set;}

        public override Microsoft.ProjectServer.Client.Event GetByInt(System.Int32 @id)
        {
            return GetByIntEx;
        }
        public Microsoft.ProjectServer.Client.Event GetByIntEx { get; set;}

    }
}

