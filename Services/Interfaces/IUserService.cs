using Domain.Entities;
using Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetAll();

        User Authenticate(string username, string password);
    }
}
