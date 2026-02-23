using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameApi.Business.Interfaces;
using VideoGameApi.Business.Models;
using VideoGameApi.Business.Repository_Interfaces;
using VideoGameApi.Data.Entities;

namespace VideoGameApi.Business.Servicios
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher<UserEntity> _passwordHasher;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _passwordHasher = new PasswordHasher<UserEntity>();
        }

        public async Task RegisterAsync(RegisterRequest request)
        {
            var user = new UserEntity
            {
                Username = request.Email
            };

            user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);

            await _userRepository.AddAsync(user);
        }
    }
}
