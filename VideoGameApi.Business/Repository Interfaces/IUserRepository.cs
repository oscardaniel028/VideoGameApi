using VideoGameApi.Data.Entities;

namespace VideoGameApi.Business.Repository_Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(UserEntity user);
        Task<UserEntity> GetByUsernameAsync(string email);
    }
}
