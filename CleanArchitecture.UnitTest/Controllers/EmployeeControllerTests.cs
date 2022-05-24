//using AutoFixture;
//using CleanArchitecture.Application.DTO;
//using CleanArchitecture.Application.Interfaces;
//using CleanArchitecture.Controllers;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Moq;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace CleanArchitecture.UnitTest.Controllers
//{
//    [TestFixture]
//    public class EmployeeControllerTests
//    {
//        private MockRepository mockRepository;

//        private Mock<IEmployeeManager> mockEmployeeManager;
//        private Fixture fixture;

//        [SetUp]
//        public void SetUp()
//        {
//            fixture = new Fixture();
//            this.mockRepository = new MockRepository(MockBehavior.Default);

//            this.mockEmployeeManager = this.mockRepository.Create<IEmployeeManager>();
//        }

//        private EmployeeController CreateEmployeeController()
//        {
//            return new EmployeeController(
//                this.mockEmployeeManager.Object);
//        }

//        [Test]
//        public async Task Get_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var data = fixture.Create<IReadOnlyList<EmployeeModel>>();
//            var employeeController = this.CreateEmployeeController();
//            mockEmployeeManager.Setup(a => a.GetEmployee()).ReturnsAsync(data);
//            // Act
//            var result = await employeeController.Get();
//            var okResult = result as OkObjectResult;
//            var result1 = okResult.Value;

//            // Assert
//            Assert.IsNotNull(okResult);
//            Assert.AreEqual(data, result1);
//            Assert.AreEqual(StatusCodes.Status200OK, okResult.StatusCode);
//        }

//        [Test]
//        public async Task GetbyId_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var employeeController = this.CreateEmployeeController();
//            int id = 0;

//            // Act
//            var result = await employeeController.GetbyId(
//                id);

//            // Assert
//            Assert.Fail();
//            this.mockRepository.VerifyAll();
//        }

//        [Test]
//        public async Task GetbyLastName_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var employeeController = this.CreateEmployeeController();
//            string lastName = null;

//            // Act
//            var result = await employeeController.GetbyLastName(
//                lastName);

//            // Assert
//            Assert.Fail();
//            this.mockRepository.VerifyAll();
//        }

//        [Test]
//        public async Task AddEmployee_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var employeeController = this.CreateEmployeeController();
//            EmployeeModel employee = null;

//            // Act
//            var result = await employeeController.AddEmployee(
//                employee);

//            // Assert
//            Assert.Fail();
//            this.mockRepository.VerifyAll();
//        }

//        [Test]
//        public async Task UpdateEmployee_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var employeeController = this.CreateEmployeeController();
//            EmployeeModel employee = null;

//            // Act
//            await employeeController.UpdateEmployee(
//                employee);

//            // Assert
//            Assert.Fail();
//            this.mockRepository.VerifyAll();
//        }

//        [Test]
//        public async Task DeleteEmployee_StateUnderTest_ExpectedBehavior()
//        {
//            // Arrange
//            var employeeController = this.CreateEmployeeController();
//            EmployeeModel employee = null;

//            // Act
//            await employeeController.DeleteEmployee(
//                employee);

//            // Assert
//            Assert.Fail();
//            this.mockRepository.VerifyAll();
//        }
//    }
//}
