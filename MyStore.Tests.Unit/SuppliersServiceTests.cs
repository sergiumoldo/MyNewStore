using FluentAssertions;
using MyStore.MyStore.Data.Interfaces;
using MyStore.MyStore.Services.Interfaces;
using MyStore.NewFolder;
using MyStore.Services;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Tests.Unit
{
    public class SuppliersServiceTests
    {
        public readonly ISupplierRepository mockRepository;
        public readonly ISupplierService subjectUnderTest;
        public SuppliersServiceTests()
        {
            mockRepository = Substitute.For<ISupplierRepository>();
            subjectUnderTest = new SupplierService(mockRepository);
        }

        [Fact]
        public void GetSupplierShouldReturn_Supplier_WhenExists()
        {
            //arrange
            var existingSupplier = new Supplier()
            {
                Supplierid = 1,
                Address = "acolo",
                Companyname = "Hidronic",
                Country = "Romania"
            };

            mockRepository.GetSupplierById(existingSupplier.Supplierid)
                .Returns(existingSupplier);

            //act
            var actualResult = subjectUnderTest.GetSupplier(existingSupplier.Supplierid);

            //assert
            actualResult.Should().BeEquivalentTo(existingSupplier);
        }

        [Fact]
        public void GetSupplier_ShouldReturnNull_WhenSuplierDoesntExists()
        {
            //arrange
            var existingSupplier = new Supplier()
            {
                Supplierid = 1,
                Address = "acolo",
                Companyname = "Hidronic",
                Country = "Romania"
            };

            mockRepository.GetSupplierById(existingSupplier.Supplierid).Returns(null as Supplier);

            //act

            var actualResult = subjectUnderTest.GetSupplier(existingSupplier.Supplierid);

            //assert

            actualResult.Should().BeNull();
        }

        [Fact]
        public void GetSuppliers_ShouldReturnListOfSuppliers()
        {
            //arrange
            var page = 3;

            var suppliers = new List<Supplier>()
            {
                new Supplier()
                {
                    Supplierid = 1,
                    Address = "acolo",
                    Companyname = "Hidronic",
                    Country = "Romania"
                },

                 new Supplier()
                {
                    Supplierid = 2,
                    Address = "mai incolo",
                    Companyname = "Microsoft",
                    Country = "USA"
                },
            };

            mockRepository.GetAll(page).Returns(suppliers);

            //act

            var actualResult = subjectUnderTest.GetSuppliers(page);

            //assert

            actualResult.Should().BeEquivalentTo(suppliers);
            ;
        }
    }
}
