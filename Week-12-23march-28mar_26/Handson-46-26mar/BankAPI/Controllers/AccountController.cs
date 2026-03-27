using Microsoft.AspNetCore.Mvc;
using BankAPI.Data;
using BankAPI.DTOs;
using AutoMapper;
using BankAPI.Models;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AccountController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // ✅ GET ALL ACCOUNTS
        [HttpGet]
        public IActionResult GetAll()
        {
            var accounts = _context.Accounts.ToList();

            var result = _mapper.Map<List<AccountDTO>>(accounts);

            return Ok(result);
        }

        // ✅ CREATE ACCOUNT
        [HttpPost]
        public IActionResult Create(AccountCreateDTO dto)
        {
            var account = new Account
            {
                AccountHolderName = dto.AccountHolderName,
                AccountNumber = dto.AccountNumber,
                Balance = 1000
            };

            _context.Accounts.Add(account);
            _context.SaveChanges();

            return Ok("Account Created");
        }
    }
}