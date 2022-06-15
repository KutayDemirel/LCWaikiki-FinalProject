using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniCommerce.Persistence.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3029a764-6a3a-449e-97f7-47e894dd2ac2", "AQAAAAEAACcQAAAAEALXsS2eMsatIkudmIF5qogcN6ZnspRIyp0zyD/5aD4tkDP+fONfQ05QkBxeLYChBQ==", "6d831826-8f58-4919-b74d-b1c3047e9887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4b38e6c-f26d-4704-bb4b-61f6e92d185f", "AQAAAAEAACcQAAAAEFEnKoYWDA5REwdDVuhIcUNCgCBkiELLCPGSOptZYHD4SG8+atYUBeA3p7iCaQLMQQ==", "caa06908-1d9c-40d6-9a6b-456031cab0fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f29f285-da46-4794-a452-2dd5cec34131", "AQAAAAEAACcQAAAAEFEBJ2aAY8OF95Pfm5luVfZP3vLvRXlMTevtSXCcaW4iweM4HCFD9sHW9KqAmi9hhQ==", "2cc2d5c3-33e9-4ede-afdf-503684ed36d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "647cf05e-b262-4e21-9df8-b4cf81815168", "AQAAAAEAACcQAAAAEEDiiJllm9DYkq+LMts6An+5esmY7528Ct/irlOYb5VkyURU6v9HHXKPQsw0MXx1bQ==", "312abd5e-23c1-47e1-9e77-602247dfcedd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abd10ed4-f9a9-474c-8205-feba049d588d", "AQAAAAEAACcQAAAAEKSocIG+Ir3icu3g9dVI8wnH/tYn6WLQZ2sbCOsN340IrtSwLWwo2z9hTaxduPOiHQ==", "7a59d923-7ab4-4b92-819e-09cda269ea6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5f538bc-e164-4603-9b1c-8da14e95ee87", "AQAAAAEAACcQAAAAEIatt06se/WvOl1i7zLt+MAWqnx6WVhxBMKMmHypymu95W5/GUXS6k+TxuJwLDunsQ==", "f2ce2e00-af6b-4553-a703-137e74d3a00c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d55178d-0f01-4171-b565-21963fb513f4", "AQAAAAEAACcQAAAAEFU80SAZq6i4Fkj4e0hFqtjSDHiOt6hCrmXK6XcfGPo7AznDD1V3i4lMH1XL5ECJHw==", "1c5c855a-a702-4499-ac07-ef9ecdbbd9d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2b6682d-e098-4f82-985d-10d15fa6414d", "AQAAAAEAACcQAAAAEDuTTpyXo5BphC91PqRxYnQCt72cQSjiug1gm7JS7/jaGQRrTxqLJsQjC33UBkk2lA==", "6fc68e24-659c-4927-a50f-4313cf388918" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e261c270-f554-48d0-8bf9-5e8e6abe77ec", "AQAAAAEAACcQAAAAED+vV6YtNtgKXzdwbFdT+a+RyAyxvTb9NKmRsZ4lgZAMddORoLT50Ypu7qPo50WUHg==", "a64ff488-a17d-4403-a61e-7b4e644eb3fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "967790e2-4bee-4bfc-9cf8-b059a06fd57c", "AQAAAAEAACcQAAAAEPFWCkkTKIysTmTVweg6GLTqrzzU0IfQnk2MipD2/NunjAi7tggrShLzo+RkHOldoQ==", "51cc305e-29dd-49cf-99f9-8e7fa71fef59" });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreatedDate", "Price", "ProductId", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 33, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 63.00m, 4, null, 4 },
                    { 32, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 76.00m, 3, null, 4 },
                    { 31, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.00m, 2, null, 3 },
                    { 30, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.00m, 1, null, 3 },
                    { 28, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 76.00m, 3, null, 4 },
                    { 27, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.00m, 2, null, 3 },
                    { 26, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.00m, 1, null, 3 },
                    { 25, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 63.00m, 3, null, 4 },
                    { 24, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 76.00m, 3, null, 4 },
                    { 23, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.00m, 2, null, 3 },
                    { 22, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.00m, 1, null, 3 },
                    { 21, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 63.00m, 4, null, 4 },
                    { 20, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 76.00m, 3, null, 4 },
                    { 19, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 56.00m, 2, null, 3 },
                    { 29, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 63.00m, 4, null, 4 },
                    { 18, new DateTime(2022, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 95.00m, 1, null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7f3759a-a4f8-416e-b100-ced8454ef3aa", "AQAAAAEAACcQAAAAEN3JGm8XQQAoQu6mgJLFUQcJAtwY4bStyhByi8RCuzzOI9xAj2SfsJwliWvGtkkt4Q==", "4401613d-606e-4aaf-9b09-e9d92ed2b2c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a242f6c-9876-49db-88b6-50b09974893a", "AQAAAAEAACcQAAAAELYdatN3QKRcMWghR0BhsbX6IoZmyqKM/HdZCEggPu0r7wDjIq18fhfCM8v9th69Bw==", "e3cfc8fd-6d2d-48b3-9204-18e5eb3a8e8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d55b73-e60a-4961-ab6e-7cab3d34ff57", "AQAAAAEAACcQAAAAEEx3FGuTJin2ncOlKo/inweajdTsT4lAt+9La5GblPHBTcFxZ8XRuYB4DdYw+z38dQ==", "449dfd28-0093-444d-bdfa-0da59a943e31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f8565d3-2037-42d7-ab99-29e1c4e817a4", "AQAAAAEAACcQAAAAEGYiaJ6/kk/fopPmYYqDTyXwtCwesPqlVT5B7MOmhmYJsKzIQK9aorObYDBeVrT6SA==", "5cb0b262-bbec-46b7-acb6-db19c77739b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cff518b-9468-4bc0-a530-1695957d8c6e", "AQAAAAEAACcQAAAAEC5bG1u8aH68/3ZUEIVl+tL37fJ0EJ5viKv2F2KSCytncKs0SUMTOame6mLb2Ey1kA==", "5cc562db-bbaf-42e5-bfd1-f67088ec4996" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eb3ffc6-dbe2-4f05-84af-4bf711f2b1a6", "AQAAAAEAACcQAAAAEJlvcvNZJm7UxZr2JKBYIhiEXo+Flj9KD0xsHspn/BhbZ653BgGcf6gKRVzgYUby/A==", "2b064e3c-6964-40a4-baed-75a5cfabc066" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58303d31-ce45-4497-9469-894c3022e6bb", "AQAAAAEAACcQAAAAEE8ZDxjoaLhs2wVS1rGnIVXrNsFR70M1fUpSn0FgsY0NQALWKgXd+ejKCPxYatO3UA==", "6a604bd2-4e70-4f7c-bbe0-a2d4c717511e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b3b64a5-04b3-4f99-a3b3-f7cdaf6b84ef", "AQAAAAEAACcQAAAAEGoRkOTXH2JRY8oVzwaWVIZreKC8SVwYK93GEWQOJrabXE7ziywmXZgKpGPLXM6jLQ==", "cfb7dcdd-05cf-4d4f-9dd6-1e6ba372a3d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4df4d6b-799b-4131-977d-6e8b346a32a4", "AQAAAAEAACcQAAAAEJSmxm4futF3PibY/mkVy6d87lm4EIAvNHoHkQr6q+5dP3pbFe/laHFGzaxm255EQQ==", "ab84c1f5-e8db-4b1f-ad3e-63a4bb3ccd27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84ef24c-bc9d-41c2-9b89-562acb1c2ac9", "AQAAAAEAACcQAAAAEHCiZWXq7/l3TRW2y0MHOGH6IJBAGKywHdAlzH2Po3HWOmvONtNYddFbX8YX8nyYaQ==", "8991dba1-00e5-4465-9cdc-60c6ded35805" });
        }
    }
}
