using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineBankingWebApi.Entities.DTOs;
using OnlineBankingWebApi.Entities.DTOs.Account;
using OnlineBankingWebApi.Entities.DTOs.Address;
using OnlineBankingWebApi.Entities.DTOs.UserDto;
using OnlineBankingWebApi.Entities.Models;

namespace OnlineBankingWebApi.Mappers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            // Map users.
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CreateUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();

            // Map Address
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<CreateUserAddressDto, Address>().ReverseMap();
            CreateMap<UpdateUserAddressDto, Address>().ReverseMap();

            // Map Accounts.
            CreateMap<Account, AccountDto>().ReverseMap();
            CreateMap<CreateAccountDto, Account>().ReverseMap();
            CreateMap<UpdateAccountDto, Account>().ReverseMap();
        }
    }
}