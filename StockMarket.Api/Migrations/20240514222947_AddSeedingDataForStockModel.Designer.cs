﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockMarketApp.Data;

#nullable disable

namespace StockMarket.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240514222947_AddSeedingDataForStockModel")]
    partial class AddSeedingDataForStockModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("StockMarketApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("StockMarketApp.Models.AppUserStock", b =>
                {
                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StockId", "AppUserId");

                    b.HasIndex("AppUserId");

                    b.ToTable("AppUserStocks");
                });

            modelBuilder.Entity("StockMarketApp.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StockId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("StockId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("StockMarketApp.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LatestProfit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("MarketValue")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Apple Inc.",
                            Industry = "Technology",
                            LatestProfit = 10.2m,
                            MarketValue = 220000000000L,
                            Price = 145.67m,
                            Symbol = "AAPL"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Microsoft Corporation",
                            Industry = "Technology",
                            LatestProfit = 15.8m,
                            MarketValue = 210000000000L,
                            Price = 278.05m,
                            Symbol = "MSFT"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Amazon.com Inc.",
                            Industry = "Retail",
                            LatestProfit = 25.1m,
                            MarketValue = 1700000000000L,
                            Price = 3223.82m,
                            Symbol = "AMZN"
                        },
                        new
                        {
                            Id = 4,
                            CompanyName = "Alphabet Inc.",
                            Industry = "Technology",
                            LatestProfit = 20.5m,
                            MarketValue = 1600000000000L,
                            Price = 2369.01m,
                            Symbol = "GOOGL"
                        },
                        new
                        {
                            Id = 5,
                            CompanyName = "Meta Platforms Inc.",
                            Industry = "Technology",
                            LatestProfit = 12.3m,
                            MarketValue = 900000000000L,
                            Price = 311.18m,
                            Symbol = "FB"
                        },
                        new
                        {
                            Id = 6,
                            CompanyName = "Tesla Inc.",
                            Industry = "Automotive",
                            LatestProfit = 6.4m,
                            MarketValue = 570000000000L,
                            Price = 589.74m,
                            Symbol = "TSLA"
                        },
                        new
                        {
                            Id = 7,
                            CompanyName = "Berkshire Hathaway Inc.",
                            Industry = "Finance",
                            LatestProfit = 42.9m,
                            MarketValue = 600000000000L,
                            Price = 418715.00m,
                            Symbol = "BRK-A"
                        },
                        new
                        {
                            Id = 8,
                            CompanyName = "NVIDIA Corporation",
                            Industry = "Technology",
                            LatestProfit = 8.7m,
                            MarketValue = 370000000000L,
                            Price = 606.25m,
                            Symbol = "NVDA"
                        },
                        new
                        {
                            Id = 9,
                            CompanyName = "JPMorgan Chase & Co.",
                            Industry = "Finance",
                            LatestProfit = 19.6m,
                            MarketValue = 470000000000L,
                            Price = 160.92m,
                            Symbol = "JPM"
                        },
                        new
                        {
                            Id = 10,
                            CompanyName = "Visa Inc.",
                            Industry = "Finance",
                            LatestProfit = 13.5m,
                            MarketValue = 450000000000L,
                            Price = 234.75m,
                            Symbol = "V"
                        },
                        new
                        {
                            Id = 11,
                            CompanyName = "Procter & Gamble Co.",
                            Industry = "Consumer Goods",
                            LatestProfit = 10.8m,
                            MarketValue = 350000000000L,
                            Price = 134.56m,
                            Symbol = "PG"
                        },
                        new
                        {
                            Id = 12,
                            CompanyName = "The Walt Disney Company",
                            Industry = "Entertainment",
                            LatestProfit = 9.7m,
                            MarketValue = 340000000000L,
                            Price = 174.78m,
                            Symbol = "DIS"
                        },
                        new
                        {
                            Id = 13,
                            CompanyName = "The Home Depot Inc.",
                            Industry = "Retail",
                            LatestProfit = 14.2m,
                            MarketValue = 350000000000L,
                            Price = 322.47m,
                            Symbol = "HD"
                        },
                        new
                        {
                            Id = 14,
                            CompanyName = "Comcast Corporation",
                            Industry = "Telecommunications",
                            LatestProfit = 8.1m,
                            MarketValue = 250000000000L,
                            Price = 55.63m,
                            Symbol = "CMCSA"
                        },
                        new
                        {
                            Id = 15,
                            CompanyName = "UnitedHealth Group Incorporated",
                            Industry = "Healthcare",
                            LatestProfit = 15.3m,
                            MarketValue = 410000000000L,
                            Price = 399.51m,
                            Symbol = "UNH"
                        },
                        new
                        {
                            Id = 16,
                            CompanyName = "Alibaba Group Holding Limited",
                            Industry = "Technology",
                            LatestProfit = 20.2m,
                            MarketValue = 600000000000L,
                            Price = 214.50m,
                            Symbol = "BABA"
                        },
                        new
                        {
                            Id = 17,
                            CompanyName = "PayPal Holdings Inc.",
                            Industry = "Technology",
                            LatestProfit = 11.9m,
                            MarketValue = 300000000000L,
                            Price = 258.65m,
                            Symbol = "PYPL"
                        },
                        new
                        {
                            Id = 18,
                            CompanyName = "Netflix Inc.",
                            Industry = "Entertainment",
                            LatestProfit = 7.6m,
                            MarketValue = 220000000000L,
                            Price = 498.62m,
                            Symbol = "NFLX"
                        },
                        new
                        {
                            Id = 19,
                            CompanyName = "Salesforce.com Inc.",
                            Industry = "Technology",
                            LatestProfit = 8.9m,
                            MarketValue = 220000000000L,
                            Price = 224.38m,
                            Symbol = "CRM"
                        },
                        new
                        {
                            Id = 20,
                            CompanyName = "Intel Corporation",
                            Industry = "Technology",
                            LatestProfit = 6.5m,
                            MarketValue = 240000000000L,
                            Price = 58.95m,
                            Symbol = "INTC"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StockMarketApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StockMarketApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockMarketApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StockMarketApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockMarketApp.Models.AppUserStock", b =>
                {
                    b.HasOne("StockMarketApp.Models.ApplicationUser", "AppUser")
                        .WithMany("AppUserStocks")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StockMarketApp.Models.Stock", "Stock")
                        .WithMany("AppUserStocks")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockMarketApp.Models.Comment", b =>
                {
                    b.HasOne("StockMarketApp.Models.ApplicationUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("StockMarketApp.Models.Stock", "Stock")
                        .WithMany("Comments")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AppUser");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("StockMarketApp.Models.ApplicationUser", b =>
                {
                    b.Navigation("AppUserStocks");
                });

            modelBuilder.Entity("StockMarketApp.Models.Stock", b =>
                {
                    b.Navigation("AppUserStocks");

                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
