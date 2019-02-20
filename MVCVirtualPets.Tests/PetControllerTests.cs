using Microsoft.AspNetCore.Mvc;
using MVCVirtualPets.Controllers;
using MVCVirtualPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MVCVirtualPets.Tests
{
    public class PetControllerTests
    {
        public PetController underTest;
        //Tets class constructor
        public PetControllerTests()
        {
            underTest = new PetController();
        }

        [Fact]
        public void Index_Returns_A_View_Result()
        {
            //var underTest = new PetController();
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Model_Has_3_Pets()
        {
            //var underTest = new PetController();
            var result = underTest.Index();
            var model = (IEnumerable<Pet>)result.Model;
            Assert.Equal(3, model.Count());
        }
        [Fact]
        public void Details_Model_Has_Correct_ID()
        {
            var expectedId = 2;
            //var underTest = new PetController();
            var result = underTest.Details(expectedId);
            var model = (Pet)result.Model;
            Assert.Equal(expectedId, model.Id);
        }
    }
}
