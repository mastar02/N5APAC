namespace PAC.Tests.WebApi;
using System.Collections.ObjectModel;

using System.Data;
using Moq;
using PAC.IBusinessLogic;
using PAC.Domain;
using PAC.WebAPI;
using Microsoft.AspNetCore.Mvc;
using PAC.IDataAccess;
using PAC.BusinessLogic;

[TestClass]
public class StudentControllerTest
{
        private readonly Mock<StudentLogic> _studentServiceMock = new Mock<StudentLogic>(MockBehavior.Strict);

        private StudentController controller;

        [TestInitialize]
        public void InitTest()
        {
                controller = new StudentController(_studentServiceMock.Object);
        }

        public void createStudent ()
        {
                Assert.Fail();
        }
}
