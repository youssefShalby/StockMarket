using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMarket.Api.Migrations
{
    public partial class AddSeedingDataForStockModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CompanyName", "Industry", "LatestProfit", "MarketValue", "Price", "Symbol" },
                values: new object[,]
                {
                    { 1, "Apple Inc.", "Technology", 10.2m, 220000000000L, 145.67m, "AAPL" },
                    { 2, "Microsoft Corporation", "Technology", 15.8m, 210000000000L, 278.05m, "MSFT" },
                    { 3, "Amazon.com Inc.", "Retail", 25.1m, 1700000000000L, 3223.82m, "AMZN" },
                    { 4, "Alphabet Inc.", "Technology", 20.5m, 1600000000000L, 2369.01m, "GOOGL" },
                    { 5, "Meta Platforms Inc.", "Technology", 12.3m, 900000000000L, 311.18m, "FB" },
                    { 6, "Tesla Inc.", "Automotive", 6.4m, 570000000000L, 589.74m, "TSLA" },
                    { 7, "Berkshire Hathaway Inc.", "Finance", 42.9m, 600000000000L, 418715.00m, "BRK-A" },
                    { 8, "NVIDIA Corporation", "Technology", 8.7m, 370000000000L, 606.25m, "NVDA" },
                    { 9, "JPMorgan Chase & Co.", "Finance", 19.6m, 470000000000L, 160.92m, "JPM" },
                    { 10, "Visa Inc.", "Finance", 13.5m, 450000000000L, 234.75m, "V" },
                    { 11, "Procter & Gamble Co.", "Consumer Goods", 10.8m, 350000000000L, 134.56m, "PG" },
                    { 12, "The Walt Disney Company", "Entertainment", 9.7m, 340000000000L, 174.78m, "DIS" },
                    { 13, "The Home Depot Inc.", "Retail", 14.2m, 350000000000L, 322.47m, "HD" },
                    { 14, "Comcast Corporation", "Telecommunications", 8.1m, 250000000000L, 55.63m, "CMCSA" },
                    { 15, "UnitedHealth Group Incorporated", "Healthcare", 15.3m, 410000000000L, 399.51m, "UNH" },
                    { 16, "Alibaba Group Holding Limited", "Technology", 20.2m, 600000000000L, 214.50m, "BABA" },
                    { 17, "PayPal Holdings Inc.", "Technology", 11.9m, 300000000000L, 258.65m, "PYPL" },
                    { 18, "Netflix Inc.", "Entertainment", 7.6m, 220000000000L, 498.62m, "NFLX" },
                    { 19, "Salesforce.com Inc.", "Technology", 8.9m, 220000000000L, 224.38m, "CRM" },
                    { 20, "Intel Corporation", "Technology", 6.5m, 240000000000L, 58.95m, "INTC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
