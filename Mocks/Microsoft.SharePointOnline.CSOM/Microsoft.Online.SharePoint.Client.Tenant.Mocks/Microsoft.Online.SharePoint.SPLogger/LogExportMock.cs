
// ReSharper disable IdentifierTypo
namespace Microsoft.Online.SharePoint.SPLogger
{
    public class LogExportMock : LogExport
    {


        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetLogTypes()
        {
            return GetLogTypesEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetLogTypesEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetPartitions(System.String @logType)
        {
            return GetPartitionsEx;
        }
        public Microsoft.SharePoint.Client.ClientArrayResult<System.String> GetPartitionsEx { get; set;}

        public override Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.SPLogger.LogFileInfo> GetFiles(System.String @partitionId, System.String @logType)
        {
            return GetFilesEx;
        }
        public Microsoft.SharePoint.Client.ClientObjectList<Microsoft.Online.SharePoint.SPLogger.LogFileInfo> GetFilesEx { get; set;}

    }
}

