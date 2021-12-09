using API.Data;
using API.DTOs;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UsersController : BaseAPIController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            this.mapper = mapper;
        }

        //[HttpGet]
        //[AllowAnonymous]
        //public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        //{

        //    return await _userRepository.
        //}

        // api/users/requestedid
        //[Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDTO>> GetUser(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            return this.mapper.Map<MemberDTO>(user);
        }



    }
}
