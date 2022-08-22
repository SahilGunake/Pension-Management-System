using AuthorizationService.Models;

namespace AuthorizationService.Repository
{
    public interface ILoginRepo
    {
        public string Login(Credentials request);
        public bool Registration(Credentials request);
    }
}
