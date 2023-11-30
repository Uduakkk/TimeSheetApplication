using TimesheetApplication.DB.Entities;
using TimesheetApplication.Models;

namespace TimesheetApplication.Repository
{
    public interface IUserRepository
    {
        User RegisterUser(User user);

        User GetUserById(Guid userId);

        User GetUserByUsername(string Username);

    }
}
