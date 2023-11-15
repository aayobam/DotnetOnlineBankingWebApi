using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using OnlineBankingWebApi.Entities.DTOs.Account;
using OnlineBankingWebApi.Entities.DTOs.User;
using OnlineBankingWebApi.Entities.DTOs.UserDto;
using OnlineBankingWebApi.Entities.Models;
using OnlineBankingWebApi.Helpers;

namespace OnlineBankingWebApi.Repositories
{
    public interface IAuthRepository
    {
        public Task<CustomResponse<IdentityResult>> CreateUserAsync(CreateAccountDto createAccountDto);
        public Task<CustomResponse<IdentityResult>> VerifyUserAsync(int code);
        public Task<CustomResponse<UserDto>> GetAllAsync();
        public Task<CustomResponse<IdentityResult>> GetByIdAsync(string id);
        public Task<CustomResponse<UserDto>> UpdateUserAsync(UpdateUserDto updateUserDto, string id);
        public Task<CustomResponse<IdentityResult>> DeleteUserAsync(string id);
        public Task<CustomResponse<UserDto>> Login(LoginDto loginDto);
        public Task<CustomResponse<UserDto>> PasswordRequestAsync(PasswordResetRequestDto passwordResetRequestDto);
        public Task<CustomResponse<UserDto>> SetPasswordAsync(SetPasswordDto setPasswordDto);
    }
}