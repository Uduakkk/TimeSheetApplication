using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TimesheetApplication.DB.Entities;
using TimesheetApplication.Models;
using TimesheetApplication.Repository;
using TimesheetApplication.Services_BusinessLogic;

namespace TimesheetApplication.Services_BusinessLogic
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public CreateUser RegisterUser(CreateUser user)
        {
            User newUser = new User()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                UserName = user.UserName,
            };
          
            _userRepository.RegisterUser(newUser);

            return user;
        }

       
    }
}
