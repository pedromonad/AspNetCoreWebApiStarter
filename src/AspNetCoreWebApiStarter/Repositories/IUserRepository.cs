using System.Collections.Generic;
using AspNetCoreWebApiStarter.Models;

namespace AspNetCoreWebApiStarter.Repositories
{
    public interface IUserRepository
    {
        List<UserEntity> GetAll();
        UserEntity GetSingle(int id);
        UserEntity Add(UserEntity toAdd);
        UserEntity Update(UserEntity toUpdate);
        void Delete(int id);
    }
}
