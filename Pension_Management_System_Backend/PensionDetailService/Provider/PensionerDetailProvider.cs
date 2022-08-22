using PensionDetailService.Models;
using PensionDetailService.Repository;

namespace PensionDetailService.Provider
{
    public class PensionerDetailProvider : IPensionerDetailProvider
    {
        private readonly IPensionerDetailRepo _repository;

        public PensionerDetailProvider(IPensionerDetailRepo repository)
        {
            _repository = repository;
        }

        public PensionerDetail PensionerDetailByAadhaar(string aadhaarNumber)
        {
            return _repository.PensionerDetailByAadhaar(aadhaarNumber);
        }
    }
}
