using ProcessPensionService.Models;

namespace ProcessPensionService.Repository
{
    public interface IProcessPensionRepo
    {
        public PensionerDetail GetPensionerDetail(string AadhaarNumber);
        public double CalculatePensionAmount(PensionerDetail request);
        public int ProcessPension(ProcessPensionRequest request);
    }
}
