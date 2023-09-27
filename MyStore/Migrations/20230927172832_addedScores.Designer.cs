﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyStore.NewFolder;

#nullable disable

namespace MyStore.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230927172832_addedScores")]
    partial class addedScores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyStore.NewFolder.Category", b =>
                {
                    b.Property<int>("Categoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("categoryid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Categoryid"));

                    b.Property<string>("Categoryname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("categoryname");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("description");

                    b.HasKey("Categoryid");

                    b.HasIndex(new[] { "Categoryname" }, "idx_nc_categoryname");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyStore.NewFolder.Customer", b =>
                {
                    b.Property<int>("Custid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("custid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Custid"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("address");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("city");

                    b.Property<string>("Companyname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("companyname");

                    b.Property<string>("Contactname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("contactname");

                    b.Property<string>("Contacttitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("contacttitle");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("fax");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("phone");

                    b.Property<string>("Postalcode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("postalcode");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("region");

                    b.HasKey("Custid");

                    b.HasIndex(new[] { "City" }, "idx_nc_city");

                    b.HasIndex(new[] { "Companyname" }, "idx_nc_companyname");

                    b.HasIndex(new[] { "Postalcode" }, "idx_nc_postalcode");

                    b.HasIndex(new[] { "Region" }, "idx_nc_region");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MyStore.NewFolder.Employee", b =>
                {
                    b.Property<int>("Empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("empid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Empid"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("address");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("date")
                        .HasColumnName("birthdate");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("country");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("firstname");

                    b.Property<DateTime>("Hiredate")
                        .HasColumnType("date")
                        .HasColumnName("hiredate");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("lastname");

                    b.Property<int?>("Mgrid")
                        .HasColumnType("int")
                        .HasColumnName("mgrid");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("phone");

                    b.Property<string>("Postalcode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("postalcode");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("region");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("title");

                    b.Property<string>("Titleofcourtesy")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("titleofcourtesy");

                    b.HasKey("Empid");

                    b.HasIndex("Mgrid");

                    b.HasIndex(new[] { "Lastname" }, "idx_nc_lastname");

                    b.HasIndex(new[] { "Postalcode" }, "idx_nc_postalcode");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MyStore.NewFolder.Num", b =>
                {
                    b.Property<int>("N")
                        .HasColumnType("int")
                        .HasColumnName("n");

                    b.HasKey("N");

                    b.ToTable("Nums");
                });

            modelBuilder.Entity("MyStore.NewFolder.Order", b =>
                {
                    b.Property<int>("Orderid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("orderid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Orderid"));

                    b.Property<int?>("Custid")
                        .HasColumnType("int")
                        .HasColumnName("custid");

                    b.Property<int>("Empid")
                        .HasColumnType("int")
                        .HasColumnName("empid");

                    b.Property<decimal>("Freight")
                        .HasColumnType("money")
                        .HasColumnName("freight");

                    b.Property<DateTime>("Orderdate")
                        .HasColumnType("date")
                        .HasColumnName("orderdate");

                    b.Property<DateTime>("Requireddate")
                        .HasColumnType("date")
                        .HasColumnName("requireddate");

                    b.Property<string>("Shipaddress")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("shipaddress");

                    b.Property<string>("Shipcity")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("shipcity");

                    b.Property<string>("Shipcountry")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("shipcountry");

                    b.Property<string>("Shipname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("shipname");

                    b.Property<DateTime?>("Shippeddate")
                        .HasColumnType("date")
                        .HasColumnName("shippeddate");

                    b.Property<int>("Shipperid")
                        .HasColumnType("int")
                        .HasColumnName("shipperid");

                    b.Property<string>("Shippostalcode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("shippostalcode");

                    b.Property<string>("Shipregion")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("shipregion");

                    b.HasKey("Orderid");

                    b.HasIndex(new[] { "Custid" }, "idx_nc_custid");

                    b.HasIndex(new[] { "Empid" }, "idx_nc_empid");

                    b.HasIndex(new[] { "Orderdate" }, "idx_nc_orderdate");

                    b.HasIndex(new[] { "Shippeddate" }, "idx_nc_shippeddate");

                    b.HasIndex(new[] { "Shipperid" }, "idx_nc_shipperid");

                    b.HasIndex(new[] { "Shippostalcode" }, "idx_nc_shippostalcode");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyStore.NewFolder.OrderDetail", b =>
                {
                    b.Property<int>("Orderid")
                        .HasColumnType("int")
                        .HasColumnName("orderid");

                    b.Property<int>("Productid")
                        .HasColumnType("int")
                        .HasColumnName("productid");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric(4, 3)")
                        .HasColumnName("discount");

                    b.Property<short>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("qty")
                        .HasDefaultValueSql("((1))");

                    b.Property<decimal>("Unitprice")
                        .HasColumnType("money")
                        .HasColumnName("unitprice");

                    b.HasKey("Orderid", "Productid");

                    b.HasIndex(new[] { "Orderid" }, "idx_nc_orderid");

                    b.HasIndex(new[] { "Productid" }, "idx_nc_productid");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MyStore.NewFolder.Product", b =>
                {
                    b.Property<int>("Productid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("productid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Productid"));

                    b.Property<int>("Categoryid")
                        .HasColumnType("int")
                        .HasColumnName("categoryid");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("bit")
                        .HasColumnName("discontinued");

                    b.Property<string>("Productname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("productname");

                    b.Property<int>("Supplierid")
                        .HasColumnType("int")
                        .HasColumnName("supplierid");

                    b.Property<decimal>("Unitprice")
                        .HasColumnType("money")
                        .HasColumnName("unitprice");

                    b.HasKey("Productid");

                    b.HasIndex(new[] { "Categoryid" }, "idx_nc_categoryid");

                    b.HasIndex(new[] { "Productname" }, "idx_nc_productname");

                    b.HasIndex(new[] { "Supplierid" }, "idx_nc_supplierid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyStore.NewFolder.Score", b =>
                {
                    b.Property<string>("Testid")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("testid");

                    b.Property<string>("Studentid")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("studentid");

                    b.Property<byte>("Score1")
                        .HasColumnType("tinyint")
                        .HasColumnName("score");

                    b.Property<int>("Score2")
                        .HasColumnType("int");

                    b.HasKey("Testid", "Studentid");

                    b.HasIndex(new[] { "Testid", "Score1" }, "idx_nc_testid_score");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("MyStore.NewFolder.Shipper", b =>
                {
                    b.Property<int>("Shipperid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("shipperid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Shipperid"));

                    b.Property<string>("Companyname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("companyname");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("phone");

                    b.HasKey("Shipperid");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("MyStore.NewFolder.Supplier", b =>
                {
                    b.Property<int>("Supplierid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("supplierid");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Supplierid"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("address");

                    b.Property<string>("Anything")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("city");

                    b.Property<string>("Companyname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("companyname");

                    b.Property<string>("Contactname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("contactname");

                    b.Property<string>("Contacttitle")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("contacttitle");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("country");

                    b.Property<string>("Fax")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("fax");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)")
                        .HasColumnName("phone");

                    b.Property<string>("Postalcode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("postalcode");

                    b.Property<string>("Region")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("region");

                    b.HasKey("Supplierid");

                    b.HasIndex(new[] { "Companyname" }, "idx_nc_companyname");

                    b.HasIndex(new[] { "Postalcode" }, "idx_nc_postalcode");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("MyStore.NewFolder.Test", b =>
                {
                    b.Property<string>("Testid")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("testid");

                    b.HasKey("Testid");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("MyStore.NewFolder.Employee", b =>
                {
                    b.HasOne("MyStore.NewFolder.Employee", "Mgr")
                        .WithMany("InverseMgr")
                        .HasForeignKey("Mgrid")
                        .HasConstraintName("FK_Employees_Employees");

                    b.Navigation("Mgr");
                });

            modelBuilder.Entity("MyStore.NewFolder.Order", b =>
                {
                    b.HasOne("MyStore.NewFolder.Customer", "Cust")
                        .WithMany("Orders")
                        .HasForeignKey("Custid")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("MyStore.NewFolder.Employee", "Emp")
                        .WithMany("Orders")
                        .HasForeignKey("Empid")
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Employees");

                    b.HasOne("MyStore.NewFolder.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("Shipperid")
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Shippers");

                    b.Navigation("Cust");

                    b.Navigation("Emp");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("MyStore.NewFolder.OrderDetail", b =>
                {
                    b.HasOne("MyStore.NewFolder.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Orderid")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Orders");

                    b.HasOne("MyStore.NewFolder.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Productid")
                        .IsRequired()
                        .HasConstraintName("FK_OrderDetails_Products");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MyStore.NewFolder.Product", b =>
                {
                    b.HasOne("MyStore.NewFolder.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Categoryid")
                        .IsRequired()
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("MyStore.NewFolder.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("Supplierid")
                        .IsRequired()
                        .HasConstraintName("FK_Products_Suppliers");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("MyStore.NewFolder.Score", b =>
                {
                    b.HasOne("MyStore.NewFolder.Test", "Test")
                        .WithMany("Scores")
                        .HasForeignKey("Testid")
                        .IsRequired()
                        .HasConstraintName("FK_Scores_Tests");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("MyStore.NewFolder.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MyStore.NewFolder.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MyStore.NewFolder.Employee", b =>
                {
                    b.Navigation("InverseMgr");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MyStore.NewFolder.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("MyStore.NewFolder.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("MyStore.NewFolder.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MyStore.NewFolder.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MyStore.NewFolder.Test", b =>
                {
                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
