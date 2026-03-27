using AutoMapper;
using BankAPI.Models;
using BankAPI.DTOs;

namespace BankAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountDTO>()
                .ForMember(dest => dest.MaskedAccountNumber,
                    opt => opt.MapFrom(src =>
                        new string('X', src.AccountNumber.Length - 4)
                        + src.AccountNumber.Substring(src.AccountNumber.Length - 4)
                    ));
        }
    }
}