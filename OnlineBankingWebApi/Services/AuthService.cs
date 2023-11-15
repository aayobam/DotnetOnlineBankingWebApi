using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineBankingWebApi.Data;
using OnlineBankingWebApi.Entities.DTOs.Account;
using OnlineBankingWebApi.Entities.DTOs.User;
using OnlineBankingWebApi.Entities.DTOs.UserDto;
using OnlineBankingWebApi.Entities.Models;
using OnlineBankingWebApi.Helpers;
using OnlineBankingWebApi.Repositories;

namespace OnlineBankingWebApi.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        // private readonly HttpContextAccessor _contextAccessor;

        public AuthService(ApplicationDbContext context, UserManager<User> userManager, IMapper mapper,
        IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
            _configuration = configuration;
            //_contextAccessor = contextAccessor;
        }

        public Task<CustomResponse<IdentityResult>> CreateUserAsync(CreateAccountDto createAccountDto)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<IdentityResult>> VerifyUserAsync(int code)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<UserDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<IdentityResult>> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<UserDto>> UpdateUserAsync(UpdateUserDto updateUserDto, string id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<IdentityResult>> DeleteUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<UserDto>> Login(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<UserDto>> PasswordRequestAsync(PasswordResetRequestDto passwordResetRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponse<UserDto>> SetPasswordAsync(SetPasswordDto setPasswordDto)
        {
            throw new NotImplementedException();
        }

        // private string GetUserId()
        // {
        //     return _contextAccessor.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier)!.ToString();
        // }

        private async Task<VerificationOtp> GenerateOtp(User user)
        {
            string code;
            do
            {
                code = new Random().Next(10000000, 99999999).ToString();
            }
            while (await _context.VerificationOtps.AnyAsync(otp => otp.Code == code));
            var expiryPeriod = _configuration.GetSection("MailSettings").GetValue<int>("Expires");
            var otpObjectDto = new VerificationOtp()
            {
                User = user,
                Code = code,
                Expiry = DateTime.Now.AddMinutes(expiryPeriod)
            };
            var otpDomain = _mapper.Map<VerificationOtp>(otpObjectDto);
            await _context.VerificationOtps.AddAsync(otpDomain);
            await _context.SaveChangesAsync();
            return otpObjectDto;
        }

    }
}