using Microsoft.EntityFrameworkCore;
using VideoGameApi.Business.Repository_Interfaces;
using VideoGameApi.Data.Context;
using VideoGameApi.Data.Entities;

namespace VideoGameApi.Repository.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly VideoGameDbContext _context;

        public UserRepository(VideoGameDbContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> GetByUsernameAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == email);
        }

        public async Task AddAsync(UserEntity user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
