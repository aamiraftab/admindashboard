using System;
using System.Collections.Generic;
using System.Linq;
using AdminDashboard.DAL.EF;
using AdminDashboard.Entities.Models;
using Moq;
using Shouldly;
using Xunit;

namespace AdminDashboard.UnitTests
{
    public class PersonRepositoryTest
    {
        private readonly Guid _personGuid;

        public PersonRepositoryTest()
        {
            _personGuid = new Guid();
        }

        [Fact]
        public void Create_Person_Calls_PersonRepositoryAdd()
        {
            var person = new Person { FirstName = "Aamir", LastName = "Aftab", rowguid = _personGuid, BusinessEntityID = 3 };

            var mockpersonRepository = new Mock<IPersonRepository>();
            mockpersonRepository.Setup(x => x.Add(person)); //no return as it's a void method
            mockpersonRepository.Object.Add(person);
            mockpersonRepository.Verify(x => x.Add(person), Times.Once()); //Assert that the Add method was called once



        }

        [Fact]
        public void Get_Person_By_Id()
        {
            var person = new Person { FirstName = "Aamir", LastName = "Aamir", rowguid = _personGuid, BusinessEntityID = 3 };
            var mockpersonRepository = new Mock<IPersonRepository>();

            mockpersonRepository.Setup(x => x.GetPersonById(3))
               .Returns(person); //return Person
            mockpersonRepository.Object.GetPersonById(3).ShouldBe(person); //Assert expected value equal to actual value
            mockpersonRepository.Verify(x => x.GetPersonById(person.BusinessEntityID), Times.Once()); //Assert that the Get method was called once


        }

        [Fact]
        public void Delete_Person_ById()
        {
            var person = new Person {BusinessEntityID = 3};

            var mockpersonRepository = new Mock<IPersonRepository>();
            
            
            mockpersonRepository.Setup(x => x.Delete(person));
            
            mockpersonRepository.Object.Delete(person);

            mockpersonRepository.Setup(x => x.GetPersonById(3));
            mockpersonRepository.Object.GetPersonById(3).ShouldBe(null);

            mockpersonRepository.Verify(x=>x.Delete(person),Times.Once);



        }


    }
}
