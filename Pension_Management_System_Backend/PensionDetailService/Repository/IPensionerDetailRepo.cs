using PensionDetailService.Models;

namespace PensionDetailService.Repository
{
    public interface IPensionerDetailRepo
    {
        public PensionerDetail PensionerDetailByAadhaar(string aadhaarNumber);
    }
}
