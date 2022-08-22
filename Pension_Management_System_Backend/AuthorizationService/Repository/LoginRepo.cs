using AuthorizationService.Models;
using AuthorizationService.Provider;

namespace AuthorizationService.Repository
{
    public class LoginRepo : ILoginRepo
    {
        private readonly ILoginProvider _provider;

        public LoginRepo(ILoginProvider provider)
        {
            _provider = provider;
        }

        public string Login(Credentials request)
        {
            return _provider.Login(request);
        }

        public bool Registration(Credentials request)
        {
            return _provider.Registration(request);
        }
    }
}
