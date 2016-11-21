using System;

namespace AspNetCoreWebApiStarter.Models
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool emailValidated { get; set; }   
        public DateTime Birthday { get; set; }
        public string City { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}