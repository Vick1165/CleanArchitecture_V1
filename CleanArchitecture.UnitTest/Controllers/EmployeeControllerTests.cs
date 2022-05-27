using AutoFixture;
using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.UnitTest.Controllers
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        private MockRepository mockRepository;

        private Mock<IEmployeeManager> mockEmployeeManager;
        private Fixture fixture;

        [SetUp]
        public void SetUp()
        {
            fixture = new Fixture();
            this.mockRepository = new MockRepository(MockBehavior.Default);

            this.mockEmployeeManager = this.mockRepository.Create<IEmployeeManager>();
        }

        private EmployeeController CreateEmployeeController()
        {
            return new EmployeeController(
                this.mockEmployeeManager.Object);
        }

        [Test]
        public async Task Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var data = fixture.Create<IReadOnlyList<EmployeeModel>>();
            var employeeController = this.CreateEmployeeController();
            mockEmployeeManager.Setup(a => a.GetEmployee()).ReturnsAsync(data);
            // Act
            var result = await employeeController.Get();
            var okResult = result as OkObjectResult;
            var result1 = okResult.Value;

            // Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(data, result1);
            Assert.AreEqual(StatusCodes.Status200OK, okResult.StatusCode);
        }

        [Test]
        public async Task GetbyId_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            int id;
            var data = fixture.Create<EmployeeModel>();
            var employeeController = this.CreateEmployeeController();
            mockEmployeeManager.Setup(a => a.GetEmployeebyId(1)).ReturnsAsync(data);
             

            // Act
            var result = await employeeController.GetbyId(1);
            var okResult = result as OkObjectResult;
            var result1 = okResult.Value;
            // Assert
            Assert.NotNull(okResult);
            this.mockRepository.VerifyAll();
        }

        [Test]
        public async Task GetbyLastName_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string lastName = null;
            var data = fixture.Create<IEnumerable<EmployeeModel>>();
            var employeeController = this.CreateEmployeeController();
            mockEmployeeManager.Setup(a => a.GetEmployeebyLastName("string")).ReturnsAsync(data);
            

            // Act
            var result = await employeeController.GetbyLastName("string");
            var okResult = result as OkObjectResult;
            var result1 = okResult.Value;

            // Assert
            Assert.NotNull(okResult);
            this.mockRepository.VerifyAll();
        }

        [Test]
        public async Task AddEmployee_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string FirstName;
            string LastName;
            DateTime DateOfBirth;
            string PhoneNumber;
            string Email;
            string Email2;
            int DepartmentId;
            var data = fixture.Create<EmployeeModel>();
            var employeeController = this.CreateEmployeeController();
            EmployeeModel employee = null;
            mockEmployeeManager.Setup(a => a.AddEmployee(employee)).ReturnsAsync(data);

            // Act
            var result = await employeeController.AddEmployee(employee);
            var okResult = result as OkObjectResult;
            var result1 = okResult.Value;

            // Assert
            Assert.NotNull(okResult);
            this.mockRepository.VerifyAll();
        }

        [Test]
        public async Task UpdateEmployee_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string FirstName;
            string LastName;
            DateTime DateOfBirth;
            string PhoneNumber;
            string Email;
            string Email2;
            int DepartmentId;
            var data = fixture.Create<EmployeeModel>();
            var employeeController = this.CreateEmployeeController();
            EmployeeModel employee = null;
            mockEmployeeManager.Setup(a => a.UpdateEmployee(employee));

            // Act
            var result = await employeeController.UpdateEmployee(employee);

            // Assert
            Assert.IsInstanceOf<OkResult>(result);
            this.mockRepository.VerifyAll();
        }

        [Test]
        public async Task DeleteEmployee_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string FirstName;
            string LastName;
            DateTime DateOfBirth;
            string PhoneNumber;
            string Email;
            string Email2;
            int DepartmentId;
            var data = fixture.Create<EmployeeModel>();
            var employeeController = this.CreateEmployeeController();
            EmployeeModel employee = null;
            mockEmployeeManager.Setup(a => a.DeleteEmployee(employee));

            // Act
            var result = await employeeController.DeleteEmployee(employee);

            // Assert
            Assert.IsInstanceOf<OkResult>(result);
            this.mockRepository.VerifyAll();
        }
    }
}
