using ProcessPensionService.Models;

namespace ProcessPensionService.Provider
{
    public interface IProcessPensionProvider
    {
        public PensionDetail PensionDetail(string aadhaarNumber);
        public string ProcessPension(ProcessPensionRequest request);
    }
}
