using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dtos
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            this.user = new List<User>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public List<User> user { get; set; }
    }
}
