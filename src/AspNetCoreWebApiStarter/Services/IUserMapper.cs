using AspNetCoreWebApiStarter.Models;

namespace AspNetCoreWebApiStarter.Services
{
    public interface IUserMapper
    {
        UserDto MapToDto(UserEntity userEntity);
        UserEntity MapToEntity(UserDto userDto);
    }
}