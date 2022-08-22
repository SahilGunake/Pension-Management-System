namespace AuthorizationService.Models
{
    public class SignInResponse
    {
        public bool IsSuccess { get; set; }
        public string Token { get; set; }
    }
}
