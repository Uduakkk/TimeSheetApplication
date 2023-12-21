using TimesheetApplication.DB.Entities;
using TimesheetApplication.DB.WriteAndReadFromJson;
using TimesheetApplication.Models;

namespace TimesheetApplication.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly WriteToJson _writeToJson;
        private readonly ReadFromJson _readFromJson;
        private readonly string userFileName = "user.json";

        public UserRepository(WriteToJson writeToJson, ReadFromJson readFromJson) 
        {
            _writeToJson = writeToJson;
            _readFromJson = readFromJson;
        }

        public User RegisterUser(User user)
        {
            try
            {
                List<User> listOfUsers = _readFromJson.ReadFromJsons<User>(userFileName);

                listOfUsers.Add(user);

                _writeToJson.WriteToJsons<User>(listOfUsers, userFileName);

                return user;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public User GetUserById(Guid userId)
        {
            try
            {
                List<User> listOfUsers = _readFromJson.ReadFromJsons<User>(userFileName);

                User user = listOfUsers.FirstOrDefault(u => u.Id == userId);

                return user;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public User GetUserByUsername(string Username)
        {
            try
            {
                List<User> listOfUsers = _readFromJson.ReadFromJsons<User>(userFileName);

                User user = listOfUsers.FirstOrDefault(u => u.UserName == Username);

                return user;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }




    }
}
