using VideoGameApi.Business.Models;

namespace VideoGameApi.Business.Interfaces
{
    public interface IAuthenticationService
    {
        public Task<string> LoginAsync(LoginRequest loginRequest);
    }
}
