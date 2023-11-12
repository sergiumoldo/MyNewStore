using FluentAssertions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyStore.Controllers;
using MyStore.Helpers;
using MyStore.Models;
using MyStore.MyStore.Services.Interfaces;
using MyStore.NewFolder;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Tests.Unit
{
    public class CategoriesControllerTests
    {
        private readonly ICategoryService categoryService;
        private readonly CategoriesController sut;
        public CategoriesControllerTests()
        {
            this.categoryService = Substitute.For<ICategoryService>();
            sut = new CategoriesController(this.categoryService);
        }

        [Fact]
        public void GetById_ReturnsNotFound_WhenCategoryDoesntExists()
        {
            //arrange
            categoryService.GetCategory(Arg.Any<int>()).ReturnsNull();

            //act
            var result = sut.GetById(Arg.Any<int>());

            //assert
            result.Result.Should().BeOfType<NotFoundResult>();
            result.ReturnsNull();
        }

        [Fact]
        public void GetById_ReturnsOk_WhenCategoryExists()
        {
            //arrange
            var existingCategory = new Category()
            {
                Categoryid = 1,
                Categoryname = "Test category",
                Description = "Test description",
            };

            var objectToReturn = existingCategory.ToCategoryModel();

            categoryService.GetCategory(1).Returns(existingCategory);

            //act
            var result = sut.GetById(1);

            //assert
            result.Should().BeOfType<ActionResult<CategoryModel>>();
            result.Result.Should().BeOfType<OkObjectResult>();
            //result.Result.Should().Be(objectToReturn);
        }
    }
}
