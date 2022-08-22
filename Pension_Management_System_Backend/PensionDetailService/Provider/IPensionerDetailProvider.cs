using PensionDetailService.Models;

namespace PensionDetailService.Provider
{
    public interface IPensionerDetailProvider
    {
        public PensionerDetail PensionerDetailByAadhaar(string aadhaarNumber);
    }
}
