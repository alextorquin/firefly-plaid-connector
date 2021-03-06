﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using firefly_plaid_connector;

namespace firefly_plaid_connector.Migrations
{
    [DbContext(typeof(ImportDbContext))]
    partial class ImportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("firefly_plaid_connector.ImportedTransaction", b =>
                {
                    b.Property<int>("ImportedTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FireflyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlaidId")
                        .HasColumnType("TEXT");

                    b.HasKey("ImportedTransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("firefly_plaid_connector.LastPoll", b =>
                {
                    b.Property<int>("LastPollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlaidId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("LastPollId");

                    b.ToTable("Poll");
                });
#pragma warning restore 612, 618
        }
    }
}
