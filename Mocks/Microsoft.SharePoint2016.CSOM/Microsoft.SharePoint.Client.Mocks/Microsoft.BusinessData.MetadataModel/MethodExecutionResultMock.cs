
namespace Microsoft.BusinessData.MetadataModel
{
    public class MethodExecutionResultMock : MethodExecutionResult
    {


        public override Microsoft.BusinessData.MetadataModel.ReturnParameterCollection ReturnParameterCollection => ReturnParameterCollectionEx;
        public Microsoft.BusinessData.MetadataModel.ReturnParameterCollection ReturnParameterCollectionEx { get; set; }

    }
}

