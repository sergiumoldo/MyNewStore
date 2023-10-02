using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using MyStore.MyStore.Data.Interfaces;
using MyStore.MyStore.Services.Interfaces;
using MyStore.NewFolder;
using MyStore.Services;
using NSubstitute;

namespace MyStore.Tests.Unit
{
    public class CategoriesServiceTests
    {
        public readonly ICategoryService subjectUnderTest;
        public readonly ICategoryRepository mockRepository;

        public CategoriesServiceTests()
        {
            mockRepository = Substitute.For<ICategoryRepository>();
            subjectUnderTest = new CategoryService(mockRepository);
        }

        [Fact]
        public void GetCategoryShouldReturn_Category_WhenExists()
        {
            //arrange
            var existingCategory = new Category()
            {
                Categoryid = 1,
                Categoryname = "Test category",
                Description = "Test description",
            };

            mockRepository.GetCategoryById(existingCategory.Categoryid)
                .Returns(existingCategory);

            //act
            var actualResult = subjectUnderTest.GetCategory(existingCategory.Categoryid);

            //assert
            actualResult.Should().BeEquivalentTo(existingCategory);
        }

        [Fact]
        public void IsDuplicate_ShouldReturnTrue_WhenCategoryNameExists()
        {
            //arrange
            var categoryToSearch = "fructe";

            var categoryList = new List<Category>()
            {
                new Category()
                {
                    Categoryid = 1,
                    Categoryname = "Test category",
                    Description= "Test description",
                },
                new Category()
                {
                    Categoryid = 3,
                    Categoryname = "fructe",
                    Description= "Test description",
                }
            };

            mockRepository.GetAll().Returns(categoryList.AsQueryable());

            //act
            var actualResult = subjectUnderTest.IsDuplicate(categoryToSearch);

            //assert
            actualResult.Should().BeTrue();
        }

        [Fact]
        public void Get_ShouldReturnListOfCategoriesWhenExists()
        {
            //arrange
            var page = 2;

            var categoryList = new List<Category>()
            {
                new Category()
                {
                    Categoryid = 1,
                    Categoryname = "Test category",
                    Description= "Test description",
                },
                new Category()
                {
                    Categoryid = 3,
                    Categoryname = "fructe",
                    Description= "Test description",
                }
            };

            mockRepository.GetAll(page).Returns(categoryList);

            //act

            var actualResult = subjectUnderTest.GetCategories(page);

            //assert

            actualResult.Should().BeEquivalentTo(categoryList);
        }

        [Fact]
        public void InsertNew_ReturnsCategoryWhenInserted()
        {

            //arrange
            var category = new Category()
            {
                Categoryid = 6,
                Categoryname = "fructe",
                Description = "proaspete",
            };

            mockRepository.Add(category).Returns(category);

            //act

            var actualResult = subjectUnderTest.InsertNew(category);

            //assert

            actualResult.Should().BeEquivalentTo(category);
        }

        [Fact]
        public void Remove_ReturnsCategoryWhenDeleted()
        {
            //arrange
            var categoryToDelete = new Category()
            {
                Categoryid = 6,
                Categoryname = "fructe",
                Description = "proaspete",
            };

            mockRepository.Delete(categoryToDelete).Returns(categoryToDelete.Categoryid);

            //act

            var actualResult = subjectUnderTest.Remove(categoryToDelete);

            //assert 

            actualResult.Should().Be(categoryToDelete.Categoryid);
        }


        [Fact]
        public void Update_ReturnsCategoryWhenUpdated()
        {
            //arrange
            var categoryToUpdate = new Category()
            {
                Categoryid = 6,
                Categoryname = "fructe",
                Description = "proaspete",
            };

            mockRepository.Update(categoryToUpdate).Returns(categoryToUpdate);

            //act

            var actualResult = subjectUnderTest.Update(categoryToUpdate);
            //assert 

            actualResult.Should().Be(categoryToUpdate);
        }

        [Fact]
        public void Update_ReturnsNullWhenCategoryDoesntExists()
        {
            //arrange
            var categoryToUpdate = new Category()
            {
                Categoryid = 6,
                Categoryname = "fructe",
                Description = "proaspete",
            };

            mockRepository.Update(categoryToUpdate).Returns(null as Category);

            //act

            var actualResult = subjectUnderTest.Update(categoryToUpdate);
            //assert 

            actualResult.Should().BeNull();
        }

        [Fact]
        public void Update_ReturnsNullWhenCategoryIsNull()
        {
            //arrange

            Category categoryToUpdate = null;

            //act

            var actualResult = subjectUnderTest.Update(categoryToUpdate);

            //assert 

            actualResult.Should().BeNull();
        }
    }


}
