using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VideoGameApi.Business.Interfaces;
using VideoGameApi.Business.Models;
using VideoGameApi.Business.Repository_Interfaces;
using VideoGameApi.Data;
using VideoGameApi.Data.Context;
using VideoGameApi.Data.Entities;

namespace VideoGameApi.Business.Servicios
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly PasswordHasher<UserEntity> _passwordHasher;
        public AuthenticationService(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator)
        {
            _userRepository = userRepository;
            _jwtTokenGenerator = jwtTokenGenerator;
            _passwordHasher = new PasswordHasher<UserEntity>();
        }


        public async Task<string> LoginAsync(LoginRequest loginRequest)
        {
            var user = await _userRepository.GetByUsernameAsync(loginRequest.Email);
            if (user == null)
                return null;

            var result = _passwordHasher.VerifyHashedPassword(user,user.PasswordHash, loginRequest.Password);

            if (result == PasswordVerificationResult.Success)
            {
                return _jwtTokenGenerator.GenerateToken(user);
            }

            return null;
        }
    }
}
