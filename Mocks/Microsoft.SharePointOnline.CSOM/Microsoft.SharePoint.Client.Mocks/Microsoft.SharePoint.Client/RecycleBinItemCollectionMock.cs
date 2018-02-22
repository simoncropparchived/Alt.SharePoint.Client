
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class RecycleBinItemCollectionMock : RecycleBinItemCollection
    {


        public override Microsoft.SharePoint.Client.RecycleBinItem GetById(System.Guid @id)
        {
            return GetByIdEx;
        }
        public Microsoft.SharePoint.Client.RecycleBinItem GetByIdEx { get; set;}

        public override void MoveAllToSecondStage()
        {
        }

        public override void DeleteAll()
        {
        }

        public override void RestoreAll()
        {
        }

        public override void DeleteAllSecondStageItems()
        {
        }

    }
}

