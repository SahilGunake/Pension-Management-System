using AuthorizationService.Models;

namespace AuthorizationService.Provider
{
    public interface ILoginProvider
    {
        public string Login(Credentials request);
        public bool Registration(Credentials request);
    }
}
