namespace PAC.Tests.WebApi;
using System.Collections.ObjectModel;

using System.Data;
using Moq;
using PAC.IBusinessLogic;
using PAC.Domain;
using PAC.WebAPI;
using Microsoft.AspNetCore.Mvc;
using PAC.IDataAccess;

[TestClass]
public class StudentControllerTest
{
        private readonly Mock<IStudentsRepository<Student>> _studentRepositoryMock = new Mock<IStudentsRepository<Student>>(MockBehavior.Strict);

        private StudentController controller;

        [TestInitialize]
        public void InitTest()
        {
                controller = new StudentController(_studentRepositoryMock.Object);
        }

        public void createStudent ()
        {
                Assert.Fail();
        }
}
