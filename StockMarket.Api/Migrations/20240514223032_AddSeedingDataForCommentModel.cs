using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMarket.Api.Migrations
{
    public partial class AddSeedingDataForCommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AppUserId", "Content", "CreatedOn", "StockId", "Title" },
                values: new object[,]
                {
                    { 1, null, "Apple has consistently produced innovative products.", new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(8204), 1, "Great company!" },
                    { 2, null, "AAPL's stock price has been steadily increasing.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(8988), 1, "Rising stock price" },
                    { 3, null, "Excited about Apple's upcoming product launches.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(8997), 1, "Future prospects" },
                    { 4, null, "Microsoft's cloud business is driving impressive growth.", new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9004), 2, "Strong growth" },
                    { 5, null, "MSFT remains one of the largest tech companies globally.", new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9011), 2, "Tech giant" },
                    { 6, null, "Microsoft's products span from software to hardware, providing stability.", new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9028), 2, "Diverse portfolio" },
                    { 7, null, "Amazon's e-commerce platform continues to dominate the market.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9035), 3, "E-commerce dominance" },
                    { 8, null, "AMZN's investments in technology and logistics drive innovation.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9043), 3, "Innovative company" },
                    { 9, null, "Amazon Web Services (AWS) remains a key driver of growth.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9051), 3, "Expanding cloud business" },
                    { 10, null, "Google's search engine continues to dominate the market.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9060), 4, "Search engine dominance" },
                    { 11, null, "GOOGL's moonshot projects demonstrate their commitment to innovation.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9068), 4, "Innovative projects" },
                    { 12, null, "Google's advertising business remains a significant revenue driver.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9075), 4, "Advertising revenue" },
                    { 13, null, "Facebook's social media platforms continue to attract billions of users.", new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9084), 5, "Social media giant" },
                    { 14, null, "Meta Platforms' focus on the metaverse is generating significant interest.", new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9091), 5, "Metaverse initiatives" },
                    { 15, null, "Concerns about data privacy continue to impact FB's reputation.", new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9098), 5, "Data privacy concerns" },
                    { 16, null, "Tesla's electric vehicles continue to lead the market.", new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9105), 6, "Electric vehicle leader" },
                    { 17, null, "TSLA's advancements in battery technology are impressive.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9112), 6, "Innovative technology" },
                    { 18, null, "Tesla faces challenges in scaling production to meet demand.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9121), 6, "Production challenges" },
                    { 19, null, "Warren Buffett's value investing approach remains influential.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9129), 7, "Value investing" },
                    { 20, null, "BRK-A's portfolio includes a wide range of businesses.", new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9136), 7, "Diverse portfolio" },
                    { 21, null, "Berkshire Hathaway's long-term investment strategy is well-respected.", new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9143), 7, "Investment strategy" },
                    { 22, null, "NVIDIA's graphics technology remains at the forefront of the industry.", new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9150), 8, "Graphics technology leader" },
                    { 23, null, "NVDA's GPUs continue to dominate the gaming market.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9157), 8, "Gaming market dominance" },
                    { 24, null, "NVIDIA's AI and data center segments are driving significant growth.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9164), 8, "AI and data center growth" },
                    { 25, null, "JPM is one of the largest financial institutions globally.", new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9171), 9, "Financial services leader" },
                    { 26, null, "JPMorgan Chase's business model spans retail banking to investment banking.", new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9178), 9, "Diversified business model" },
                    { 27, null, "Regulatory scrutiny remains a challenge for JPM and other banks.", new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9186), 9, "Regulatory challenges" },
                    { 28, null, "Visa's payment network facilitates billions of transactions globally.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9193), 10, "Global payments leader" },
                    { 29, null, "V's investments in digital payments are driving growth.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9200), 10, "Digital payments growth" },
                    { 30, null, "Visa's partnerships with fintech companies strengthen its position.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9207), 10, "Partnership strategies" },
                    { 31, null, "Procter & Gamble's brands are household names worldwide.", new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9214), 11, "Consumer goods giant" },
                    { 32, null, "PG continues to innovate with new product offerings.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9221), 11, "Product innovation" },
                    { 33, null, "Procter & Gamble operates in over 180 countries.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9228), 11, "Global market presence" },
                    { 34, null, "Disney's entertainment properties span movies, TV, and theme parks.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9238), 12, "Entertainment powerhouse" },
                    { 35, null, "DIS's streaming services continue to gain subscribers.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9245), 12, "Streaming growth" },
                    { 36, null, "Disney's theme parks are seeing a gradual recovery in attendance.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9252), 12, "Theme park recovery" },
                    { 37, null, "Home Depot is the largest home improvement retailer in the U.S.", new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9259), 13, "Home improvement leader" },
                    { 38, null, "HD benefits from the trend of consumers doing home improvement projects.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9266), 13, "DIY trend" },
                    { 39, null, "Home Depot's online sales continue to grow.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9273), 13, "E-commerce growth" },
                    { 40, null, "Comcast is one of the largest telecommunications companies in the U.S.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9280), 14, "Telecommunications leader" },
                    { 41, null, "CMCSA is expanding its broadband infrastructure.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9287), 14, "Broadband expansion" },
                    { 42, null, "Comcast's acquisitions in media strengthen its content portfolio.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9294), 14, "Media acquisitions" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AppUserId", "Content", "CreatedOn", "StockId", "Title" },
                values: new object[,]
                {
                    { 43, null, "UnitedHealth is one of the largest healthcare companies in the U.S.", new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9301), 15, "Healthcare giant" },
                    { 44, null, "UNH offers a wide range of healthcare services.", new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9309), 15, "Healthcare services" },
                    { 45, null, "UnitedHealth's insurance segment remains profitable.", new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9316), 15, "Insurance segment" },
                    { 46, null, "Alibaba is the largest e-commerce company in China.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9323), 16, "E-commerce leader" },
                    { 47, null, "BABA's cloud computing business continues to grow rapidly.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9330), 16, "Cloud computing growth" },
                    { 48, null, "Alibaba faces regulatory challenges in China.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9337), 16, "Regulatory challenges" },
                    { 49, null, "PayPal is a leading provider of digital payment solutions.", new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9344), 17, "Digital payments leader" },
                    { 50, null, "PYPL's mobile payment volume continues to grow.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9351), 17, "Mobile payment growth" },
                    { 51, null, "PayPal's partnerships with merchants drive adoption.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9358), 17, "Partnership strategies" },
                    { 52, null, "Netflix remains the dominant player in the streaming industry.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9366), 18, "Streaming leader" },
                    { 53, null, "NFLX invests heavily in original content production.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9373), 18, "Content production" },
                    { 54, null, "Netflix continues to add subscribers globally.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9380), 18, "Subscriber growth" },
                    { 55, null, "Salesforce is the leading provider of customer relationship management software.", new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9387), 19, "CRM leader" },
                    { 56, null, "CRM's cloud computing segment is driving revenue growth.", new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9474), 19, "Cloud computing growth" },
                    { 57, null, "Salesforce's acquisitions expand its product offerings.", new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9481), 19, "Acquisition strategy" },
                    { 58, null, "Intel is one of the largest semiconductor companies globally.", new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9488), 20, "Semiconductor leader" },
                    { 59, null, "INTC's processors power a wide range of computing devices.", new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9495), 20, "Processor innovation" },
                    { 60, null, "Intel faces competition from AMD and other players in the data center market.", new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9502), 20, "Competition in data center market" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60);
        }
    }
}
