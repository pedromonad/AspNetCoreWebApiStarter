using System.Linq;
using AspNetCoreWebApiStarter.Models;
using System;

namespace AspNetCoreWebApiStarter.Services
{
    public class UserMapper : IUserMapper
    {
        public UserDto MapToDto(UserEntity userEntity)
        {
            return new UserDto()
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                LastName = userEntity.LastName,
                Email = userEntity.Email,
                Password = userEntity.Password,
                emailValidated = userEntity.emailValidated,
                Birthday = userEntity.Birthday,
                City = userEntity.City,
                Rg = userEntity.Rg,
                Cpf = userEntity.Cpf
            };
        }

        public UserEntity MapToEntity(UserDto userDto)
        {
            return new UserEntity()
            {
                Id = userDto.Id,
                Name = userDto.Name,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password,
                emailValidated = userDto.emailValidated,
                Birthday = userDto.Birthday,
                City = userDto.City,
                Rg = userDto.Rg,
                Cpf = userDto.Cpf
            };
        }
    }
}