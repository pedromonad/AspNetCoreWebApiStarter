using System.Collections.Generic;
using System.Linq;
using AspNetCoreWebApiStarter.Models;
using System;

namespace AspNetCoreWebApiStarter.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly Dictionary<int, UserEntity> _users = new Dictionary<int, UserEntity>();

        public UserRepository()
        {
            _users.Add(1, new UserEntity() {
                Id = 1,
                Name = "Pedro",
                LastName = "Barros",
                Email = "pedroaugust8@live.com",
                Password = "250494",
                emailValidated = false,
                Birthday = DateTime.Now,  
                City = "Araraquara",
                Rg = "4040404-4",
                Cpf = "132132132"
            });

            _users.Add(2, new UserEntity()
            {
                Id = 1,
                Name = "Haline",
                LastName = "Ferreira",
                Email = "haline.ferreira@live.com",
                Password = "250494",
                emailValidated = true,
                Birthday = DateTime.Now,
                City = "Araraquara",
                Rg = "4040404-4",
                Cpf = "132132132"
            });

        }

        public List<UserEntity> GetAll()
        {
            return _users.Select(x => x.Value).ToList();
        }

        public UserEntity GetSingle(int id)
        {
            return _users.FirstOrDefault(x => x.Key == id).Value;
        }

        public UserEntity Add(UserEntity toAdd)
        {
            int newId = !GetAll().Any() ? 1 : GetAll().Max(x => x.Id) + 1;
            toAdd.Id = newId;
            _users.Add(newId, toAdd);
            return toAdd;
        }

        public UserEntity Update(UserEntity toUpdate)
        {
            UserEntity single = GetSingle(toUpdate.Id);

            if (single == null)
            {
                return null;
            }

            _users[single.Id] = toUpdate;
            return toUpdate;
        }

        public void Delete(int id)
        {
            _users.Remove(id);
        }
    }
}