﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcCrudOprationASP.Models;

#nullable disable

namespace MvcCrudOprationASP.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    partial class TransactionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MvcCrudOprationASP.Models.Transaction", b =>
                {
                    b.Property<int>("TransationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransationId"));

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("BeneficiaryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("SWIFTCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("TransationId");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}