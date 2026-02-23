using VideoGameApi.Data.Entities;

namespace VideoGameApi.Business.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(UserEntity user);
    }
}
