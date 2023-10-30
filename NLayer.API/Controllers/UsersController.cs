using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<User> _service;
        public UsersController(IService<User> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var users = await _service.GetAllAsync();
            var usersDtos = _mapper.Map<List<UserDto>>(users.ToList());
            return CreateActionResult(CustomResponseDto<List<UserDto>>.Succes(200, usersDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _service.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(CustomResponseDto<UserDto>.Succes(200, userDto));
        }


        [HttpPost]
        public async Task<IActionResult> Save(UserDto userDto)
        {
            var user = await _service.AddAsync(_mapper.Map<User>(userDto));
            var usersDto = _mapper.Map<UserDto>(user);
            return CreateActionResult(CustomResponseDto<UserDto>.Succes(200, usersDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserDto userDto)
        {
             await _service.UpdateAsync(_mapper.Map<User>(userDto));
            
            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var user = await _service.GetByIdAsync(id);
            if (user ==null)
            {
                return CreateActionResult(CustomResponseDto<NoContentDto>.Fail(404  , "bu id ye sahip ürün bulunamadı"));

            }
            await _service.RemoveAsync(user);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
