using AutoMapper;
using Data.Interface;
using Data.Repository;
using Domain.Entities;
using Services.Dtos;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Domain;

namespace Services.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UserService(IRepository<User> userRepository, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        public UserViewModel GetAll()
        {
            var users = _userRepository.GetAll();
            var userMap = _mapper.Map<List<User>>(users);
            var userViewModel = new UserViewModel();
            foreach (var item in userMap)
                userViewModel.user.Add(item);

            return userViewModel;
        }

        public User Authenticate(string username, string password)
        {
            var user = _userRepository.Find(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (user == null)
                return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            user.Password = null;

            return user;
        }
    }
}
