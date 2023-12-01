using NUnit.Framework;
using Moq;
using TimesheetApplication.DB.WriteAndReadFromJson;
using TimesheetApplication.Repository;
using TimesheetApplication.DB.Entities;

namespace TimesheetApplication.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        private UserRepository _userRepository;
        private Mock<WriteToJson> _mockWriteToJson;
        private Mock<ReadFromJson> _mockReadFromJson;

        [SetUp]
        public void Setup()
        {
            _mockWriteToJson = new Mock<WriteToJson>();
            _mockReadFromJson = new Mock<ReadFromJson>();
            _userRepository = new UserRepository(_mockWriteToJson.Object, _mockReadFromJson.Object);
        }

        [Test]
        public void RegisterUser_WhenCalled_AddsUserToList()
        {
            // Arrange
            var user = new User { Id = Guid.NewGuid(), UserName = "testuser", Email = "test@example.com", FirstName = "Lafarge", LastName = "test", Password = "Test123#" };
            var existingUsers = new List<User>(); 

            _mockReadFromJson.Setup(r => r.ReadFromJsons<User>("user.json")).Returns(existingUsers);

            // Act
            var result = _userRepository.RegisterUser(user);

            // Assert
            _mockWriteToJson.Verify(w => w.WriteToJsons<User>(It.IsAny<List<User>>(), "user.json"), Times.Once);
            Assert.Equals(user, result);
        }

    }



}


