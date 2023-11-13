using MyStore.Models;
using MyStore.NewFolder;

namespace MyStore.Helpers
{
    public static class Extensions
    {
        public static int CountWords(this string paragraph)
        {
            var words = paragraph.Split(' ');
            return words.Length;
        }

        public static CategoryModel ToCategoryModel(this Category domainObject)
        {
            var model = new CategoryModel();

            model.Categoryid = domainObject.Categoryid;
            model.Categoryname = domainObject.Categoryname;
            model.Description = domainObject.Description;

            return model;
        }

        public static Category ToCategory(this CategoryModel domainObject)
        {
            var category = new Category();

            category.Categoryid = domainObject.Categoryid;
            category.Categoryname = domainObject.Categoryname;
            category.Description = domainObject.Description;

            return category;
        }

        public static ShipperModel ToShipperModel(this Shipper domainObject)
        {
            var model = new ShipperModel();

            model.Shipperid = domainObject.Shipperid;
            model.Phone = domainObject.Phone;
            model.Companyname = domainObject.Companyname;

            return model;
        }

        public static Shipper ToShipper(this ShipperModel domainObject)
        {
            var model = new Shipper();

            model.Shipperid = domainObject.Shipperid;
            model.Phone = domainObject.Phone;
            model.Companyname = domainObject.Companyname;

            return model;
        }

        public static SupplierModel ToSupplierModel(this Supplier domainObject)
        {
            var model = new SupplierModel();

            model.Postalcode = domainObject.Postalcode;
            model.Supplierid = domainObject.Supplierid;
            model.Address = domainObject.Address;
            model.Phone = domainObject.Phone;
            model.Companyname = domainObject.Companyname;
            model.Contactname = domainObject.Contactname;
            model.City = domainObject.City;
            model.Contacttitle = domainObject.Contacttitle;
            model.Country = domainObject.Country;
            model.Fax = domainObject.Fax;
            model.Region = domainObject.Region;

            return model;
        }

        public static Supplier ToSupplier(this SupplierModel domainObject)
        {
            var model = new Supplier();

            model.Postalcode = domainObject.Postalcode;
            model.Supplierid = domainObject.Supplierid;
            model.Address = domainObject.Address;
            model.Phone = domainObject.Phone;
            model.Companyname = domainObject.Companyname;
            model.Contactname = domainObject.Contactname;
            model.City = domainObject.City;
            model.Contacttitle = domainObject.Contacttitle;
            model.Country = domainObject.Country;
            model.Fax = domainObject.Fax;
            model.Region = domainObject.Region;

            return model;
        }

        public static EmployeeModel ToEmployeeModel(this Employee domainObject)
        {
            var model = new EmployeeModel();

            model.Firstname = domainObject.Firstname;
            model.Lastname= domainObject.Lastname;
            model.Birthdate = domainObject.Birthdate;
            model.Hiredate = domainObject.Hiredate;
            model.Address = domainObject.Address;
            model.City = domainObject.City;
            model.Email = domainObject.Email;

            return model;
        }

        public static Employee ToEmployee(this EmployeeModel domainObject)
        {
            var model = new Employee();

            model.Firstname = domainObject.Firstname;
            model.Lastname = domainObject.Lastname;
            model.Birthdate = domainObject.Birthdate;
            model.Hiredate = domainObject.Hiredate;
            model.Address = domainObject.Address;
            model.City = domainObject.City;
            model.Email = domainObject.Email;

            return model;
        }

         public static OrderDetailsModelDto ToOrderModel(this OrderDetail domainObject)
        {
            var model = new OrderDetailsModelDto();

            model.Discount = domainObject.Discount;
            model.Qty = domainObject.Qty;
            model.Order = domainObject.Order;
            model.Unitprice = domainObject.Unitprice;
            model.Product = domainObject.Product;
            model.Orderid = domainObject.Orderid;
            model.Productid = domainObject.Productid;
            

            return model;
        }
        public static OrderDetail ToOrder(this OrderDetailsModelDto domainObject)
        {
            var model = new OrderDetail();

            model.Discount = domainObject.Discount;
            model.Qty = domainObject.Qty;
            model.Order = domainObject.Order;
            model.Unitprice = domainObject.Unitprice;
            model.Product = domainObject.Product;
            model.Orderid = domainObject.Orderid;
            model.Productid = domainObject.Productid;
            

            return model;
        }


    }
}