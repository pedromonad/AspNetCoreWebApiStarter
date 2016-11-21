using System;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreWebApiStarter.Models;
using AspNetCoreWebApiStarter.Repositories;
using AspNetCoreWebApiStarter.Services;

namespace AspNetCoreWebApiStarter.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserMapper _userMapper;
        private readonly IUserRepository _userRepository;

        public UserController(IUserMapper userMapper, IUserRepository userRepository)
        {
            _userMapper = userMapper;
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_userRepository.GetAll().Select(x => _userMapper.MapToDto(x)));
            }
            catch (Exception exception)
            {
                //logg exception or do anything with it
                return StatusCode((int) HttpStatusCode.InternalServerError);
            }
        }

        [HttpGet("{id:int}", Name = "GetSingleUser")]
        public IActionResult GetSingle(int id)
        {
            try
            {
                UserEntity userEntity = _userRepository.GetSingle(id);

                if (userEntity == null)
                {
                    return NotFound();
                }

                return Ok(_userMapper.MapToDto(userEntity));
            }
            catch (Exception exception)
            {
                //logg exception or do anything with it
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPatch("{id:int}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<UserDto> userPatchDocument)
        {
            try
            {
                if (userPatchDocument == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                UserEntity userEntity = _userRepository.GetSingle(id);

                if (userEntity == null)
                {
                    return NotFound();
                }

                UserDto existingUser = _userMapper.MapToDto(userEntity);

                userPatchDocument.ApplyTo(existingUser, ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _userRepository.Update(_userMapper.MapToEntity(existingUser));

                return Ok(existingUser);
            }
            catch (Exception exception)
            {
                //logg exception or do anything with it
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                UserEntity userEntity = _userMapper.MapToEntity(userDto);

                _userRepository.Add(userEntity);
   
                return CreatedAtRoute("GetSingleUser", new { id = userEntity.Id }, _userMapper.MapToDto(userEntity));
            }
            catch (Exception exception)
            {
                //logg exception or do anything with it
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] UserDto userDto)
        {
            try
            {
                if (userDto == null)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                UserEntity userEntityToUpdate = _userRepository.GetSingle(id);

                if (userEntityToUpdate == null)
                {
                    return NotFound();
                }

                userEntityToUpdate.Name = userDto.Name;
                userEntityToUpdate.LastName = userDto.LastName;
                userEntityToUpdate.Email = userDto.Email;
                userEntityToUpdate.Password = userDto.Password;
                userEntityToUpdate.emailValidated = userDto.emailValidated;
                userEntityToUpdate.Birthday = userDto.Birthday;
                userEntityToUpdate.City = userDto.City;
                userEntityToUpdate.Rg = userDto.Rg;
                userEntityToUpdate.Cpf = userDto.Cpf;

                _userRepository.Update(userEntityToUpdate);

                return Ok(_userMapper.MapToDto(userEntityToUpdate));
            }
            catch (Exception exception)
            {
                //logg exception or do anything with it
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                UserEntity userEntityToDelete = _userRepository.GetSingle(id);

                if (userEntityToDelete == null)
                {
                    return NotFound();
                }

                _userRepository.Delete(id);

                return NoContent();
            }
            catch (Exception exception)
            {
                //logg exception or do anything with it
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}
