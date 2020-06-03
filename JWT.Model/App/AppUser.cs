using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JWT.Model
{
    public class AppUser: DefaultColumn
    {
        public AppUser()
        {
            Id = Guid.NewGuid().ToString();
        }
        [Key]
        public string Id { set; get; }
        [Required]
        public string UserName { set; get; }
        [Required]
        public string PasswordHash { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
    }
}
