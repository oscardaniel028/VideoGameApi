using VideoGameApi.Business.Models;

namespace VideoGameApi.Business.Interfaces
{
    public interface IUserService
    {
        Task RegisterAsync(RegisterRequest request);
    }
}
