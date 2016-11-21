using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApiStarter.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool emailValidated { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Rg { get; set; }

        [Required]
        public string Cpf { get; set; }
    }
}