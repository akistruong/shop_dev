﻿// <auto-generated />
using System;
using AccountShop.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Shop_Dev.EF.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240813055300_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccountShop.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BranchDsc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Branches", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryImage")
                        .HasColumnType("text");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CategoryRootId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryRootId");

                    b.HasIndex(new[] { "CategoryName" }, "idx_category");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageDsc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VariantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("VariantId");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.Iventory", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductID", "BranchID");

                    b.HasIndex("BranchID");

                    b.ToTable("Iventory");
                });

            modelBuilder.Entity("AccountShop.Entities.Option", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("OptionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductID");

                    b.ToTable("Options", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.OptionValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("OptionID")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OptionValueName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OptionID");

                    b.ToTable("OptionValues", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Ischeckout")
                        .HasColumnType("bit");

                    b.Property<decimal?>("OrderPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrderQty")
                        .HasColumnType("int");

                    b.Property<bool?>("OrderStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.Property<decimal?>("OdtPrice")
                        .HasPrecision(10)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("odt_price");

                    b.Property<int?>("OdtQty")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "VariantId");

                    b.HasIndex(new[] { "VariantId" }, "IDX_Ordt_variant");

                    b.HasIndex(new[] { "VariantId", "OrderId" }, "IX_OrderDetail");

                    b.HasIndex(new[] { "OrderId" }, "IX_orderdetail_order_id");

                    b.ToTable("OrderDetails", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("MethodDsc")
                        .HasColumnType("text");

                    b.Property<string>("MethodName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDesciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductSlug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RootId")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RootId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("nchar(20)")
                        .IsFixedLength();

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pwd")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.Variant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("VariantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("VariantPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VariantQty")
                        .HasColumnType("int");

                    b.Property<int?>("VariantRootId")
                        .HasColumnType("int");

                    b.Property<string>("VariantSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("VariantRootId");

                    b.ToTable("Variant");
                });

            modelBuilder.Entity("AccountShop.Entities.VariantAttribute", b =>
                {
                    b.Property<int>("VariantId")
                        .HasColumnType("int");

                    b.Property<int>("OptionValueID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("VariantId", "OptionValueID");

                    b.HasIndex(new[] { "OptionValueID" }, "IX_optionvalue_attribute_OptionValueID");

                    b.HasIndex(new[] { "VariantId" }, "IX_variant_attribute_VariantId");

                    b.ToTable("VariantAttributes", (string)null);
                });

            modelBuilder.Entity("AccountShop.Entities.Category", b =>
                {
                    b.HasOne("AccountShop.Entities.Category", "CategoryRoot")
                        .WithMany("InverseCategoryRoot")
                        .HasForeignKey("CategoryRootId")
                        .HasConstraintName("fk_category");

                    b.Navigation("CategoryRoot");
                });

            modelBuilder.Entity("AccountShop.Entities.Image", b =>
                {
                    b.HasOne("AccountShop.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("AccountShop.Entities.Variant", "Variant")
                        .WithMany("Images")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_image_variant");

                    b.Navigation("Product");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("AccountShop.Entities.Iventory", b =>
                {
                    b.HasOne("AccountShop.Entities.Branch", "Branch")
                        .WithMany("Iventories")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Iventory_branch");

                    b.HasOne("AccountShop.Entities.Product", "Product")
                        .WithMany("Iventories")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_Iventory_product");

                    b.Navigation("Branch");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AccountShop.Entities.Option", b =>
                {
                    b.HasOne("AccountShop.Entities.Product", "Product")
                        .WithMany("Options")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_option_product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AccountShop.Entities.OptionValue", b =>
                {
                    b.HasOne("AccountShop.Entities.Option", "Option")
                        .WithMany("OptionValues")
                        .HasForeignKey("OptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_optionvalue_option");

                    b.Navigation("Option");
                });

            modelBuilder.Entity("AccountShop.Entities.Order", b =>
                {
                    b.HasOne("AccountShop.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentMethodId")
                        .HasConstraintName("fk_order_paymentMethod");

                    b.HasOne("AccountShop.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_order_user");

                    b.Navigation("PaymentMethod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountShop.Entities.OrderDetail", b =>
                {
                    b.HasOne("AccountShop.Entities.Order", "Order")
                        .WithMany("Orderdetails")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("fk_orderdt_order");

                    b.HasOne("AccountShop.Entities.Variant", "Variant")
                        .WithMany("OrderDetails")
                        .HasForeignKey("VariantId")
                        .IsRequired()
                        .HasConstraintName("fk_orderdt_variant");

                    b.Navigation("Order");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("AccountShop.Entities.Product", b =>
                {
                    b.HasOne("AccountShop.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_category");

                    b.HasOne("AccountShop.Entities.Product", "Root")
                        .WithMany("InverseRoot")
                        .HasForeignKey("RootId")
                        .HasConstraintName("fk_product_root");

                    b.Navigation("Category");

                    b.Navigation("Root");
                });

            modelBuilder.Entity("AccountShop.Entities.Variant", b =>
                {
                    b.HasOne("AccountShop.Entities.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountShop.Entities.Variant", "VariantRoot")
                        .WithMany()
                        .HasForeignKey("VariantRootId");

                    b.Navigation("Product");

                    b.Navigation("VariantRoot");
                });

            modelBuilder.Entity("AccountShop.Entities.VariantAttribute", b =>
                {
                    b.HasOne("AccountShop.Entities.OptionValue", "OptionValue")
                        .WithMany("VariantAttributes")
                        .HasForeignKey("OptionValueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_attribute_optionvalue");

                    b.HasOne("AccountShop.Entities.Variant", "Variant")
                        .WithMany("VariantAttributes")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("fk_attribute_variant");

                    b.Navigation("OptionValue");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("AccountShop.Entities.Branch", b =>
                {
                    b.Navigation("Iventories");
                });

            modelBuilder.Entity("AccountShop.Entities.Category", b =>
                {
                    b.Navigation("InverseCategoryRoot");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("AccountShop.Entities.Option", b =>
                {
                    b.Navigation("OptionValues");
                });

            modelBuilder.Entity("AccountShop.Entities.OptionValue", b =>
                {
                    b.Navigation("VariantAttributes");
                });

            modelBuilder.Entity("AccountShop.Entities.Order", b =>
                {
                    b.Navigation("Orderdetails");
                });

            modelBuilder.Entity("AccountShop.Entities.PaymentMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AccountShop.Entities.Product", b =>
                {
                    b.Navigation("InverseRoot");

                    b.Navigation("Iventories");

                    b.Navigation("Options");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("AccountShop.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("AccountShop.Entities.Variant", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("OrderDetails");

                    b.Navigation("VariantAttributes");
                });
#pragma warning restore 612, 618
        }
    }
}