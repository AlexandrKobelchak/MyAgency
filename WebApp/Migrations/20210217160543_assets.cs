using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class assets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("1928c188-4022-4048-a652-8438174aab48"));

            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("45f2712f-26e4-41e8-8436-0a8a71263cf7"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("0af830e4-7d54-495e-a0b7-1240c9db8a02"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("1740dcf4-222f-454c-ae23-aaffab8232e4"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("25841d0e-0f64-4ec9-b395-d63e4c50f921"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("8d52bfe5-5bcf-476e-bebf-c7777710f4e0"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("a0327be5-5267-4fe9-a243-21449f4a1ed1"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("bf0659da-65f2-4c75-91c3-fc599a8b3fa2"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("d16436b5-d23b-4a1e-9570-f2a3fc65516d"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("e7607396-4bf5-4eba-bdf1-8ad36374be61"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("081e4eb3-cbd3-422c-90d1-a9196af4754b"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("6773a1fa-3046-4e35-8d1e-34817b3828a5"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("c5442fde-7017-4461-bab4-dc7263250bee"));

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fileName = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    original = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: true),
                    mime = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ext = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "SocialNetworks",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { new Guid("fa0e402c-d7f7-495f-8006-3c27b2d1a88e"), "Viber" },
                    { new Guid("5e8225d6-ec89-4d46-955b-b2057d0f0f52"), "Telegram" }
                });

            migrationBuilder.InsertData(
                table: "tags",
                columns: new[] { "id", "firstName" },
                values: new object[,]
                {
                    { new Guid("063166f4-eacc-4565-9fed-b00079568878"), "VIP" },
                    { new Guid("faaff0d1-6793-419f-8d23-ac96ae7ab237"), "Горнолыжный отдых" },
                    { new Guid("14b247a6-3681-44d1-8e95-1cae9e7cd696"), "Постоянный клиент" },
                    { new Guid("48287707-5075-4e5c-b7ba-e568c35ca3ed"), "Эконом" },
                    { new Guid("4c98c802-1b47-409b-a5cb-014cc3244966"), "Активный отдых" },
                    { new Guid("2c69d8db-35d0-4d6f-aee4-be797d55dafc"), "Ездит один" },
                    { new Guid("39f918b5-822f-438a-b123-2b866b506ee8"), "Семья" },
                    { new Guid("156d6797-6869-4514-8340-0e4daf900692"), "Экскурсионный отдых" }
                });

            migrationBuilder.InsertData(
                table: "touristProfiles",
                columns: new[] { "id", "address", "birthday", "city", "comment", "email", "firstName", "lastName", "middleName", "noSendNews", "noSendStatus" },
                values: new object[,]
                {
                    { new Guid("acb68ece-1655-4d12-aedf-ca78cc327cb3"), "Живет где-то в Днепре", new DateTime(1978, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Днепр", "Просто хороший человек", null, "Иван", "Тестовый", "Иванович", false, false },
                    { new Guid("b078bf2b-ad31-41c7-a50e-c1a1896d4552"), "Живет где-то в Киеве", new DateTime(1988, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Киев", "Очень хороший человек", null, "Владимир", "Тестовый", "Иванович", false, false },
                    { new Guid("45d7ec15-a503-4183-a59e-6067a5a26a75"), "Живет где-то в Сухачевке", new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сухачевка", "Просто хороший человек", null, "Тест", "Иванов", "Тестович", false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("5e8225d6-ec89-4d46-955b-b2057d0f0f52"));

            migrationBuilder.DeleteData(
                table: "SocialNetworks",
                keyColumn: "id",
                keyValue: new Guid("fa0e402c-d7f7-495f-8006-3c27b2d1a88e"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("063166f4-eacc-4565-9fed-b00079568878"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("14b247a6-3681-44d1-8e95-1cae9e7cd696"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("156d6797-6869-4514-8340-0e4daf900692"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("2c69d8db-35d0-4d6f-aee4-be797d55dafc"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("39f918b5-822f-438a-b123-2b866b506ee8"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("48287707-5075-4e5c-b7ba-e568c35ca3ed"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("4c98c802-1b47-409b-a5cb-014cc3244966"));

            migrationBuilder.DeleteData(
                table: "tags",
                keyColumn: "id",
                keyValue: new Guid("faaff0d1-6793-419f-8d23-ac96ae7ab237"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("45d7ec15-a503-4183-a59e-6067a5a26a75"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("acb68ece-1655-4d12-aedf-ca78cc327cb3"));

            migrationBuilder.DeleteData(
                table: "touristProfiles",
                keyColumn: "id",
                keyValue: new Guid("b078bf2b-ad31-41c7-a50e-c1a1896d4552"));

            migrationBuilder.InsertData(
                table: "SocialNetworks",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { new Guid("45f2712f-26e4-41e8-8436-0a8a71263cf7"), "Viber" },
                    { new Guid("1928c188-4022-4048-a652-8438174aab48"), "Telegram" }
                });

            migrationBuilder.InsertData(
                table: "tags",
                columns: new[] { "id", "firstName" },
                values: new object[,]
                {
                    { new Guid("25841d0e-0f64-4ec9-b395-d63e4c50f921"), "VIP" },
                    { new Guid("a0327be5-5267-4fe9-a243-21449f4a1ed1"), "Горнолыжный отдых" },
                    { new Guid("0af830e4-7d54-495e-a0b7-1240c9db8a02"), "Постоянный клиент" },
                    { new Guid("bf0659da-65f2-4c75-91c3-fc599a8b3fa2"), "Эконом" },
                    { new Guid("e7607396-4bf5-4eba-bdf1-8ad36374be61"), "Активный отдых" },
                    { new Guid("d16436b5-d23b-4a1e-9570-f2a3fc65516d"), "Ездит один" },
                    { new Guid("8d52bfe5-5bcf-476e-bebf-c7777710f4e0"), "Семья" },
                    { new Guid("1740dcf4-222f-454c-ae23-aaffab8232e4"), "Экскурсионный отдых" }
                });

            migrationBuilder.InsertData(
                table: "touristProfiles",
                columns: new[] { "id", "address", "birthday", "city", "comment", "email", "firstName", "lastName", "middleName", "noSendNews", "noSendStatus" },
                values: new object[,]
                {
                    { new Guid("6773a1fa-3046-4e35-8d1e-34817b3828a5"), "Живет где-то в Днепре", new DateTime(1978, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Днепр", "Просто хороший человек", null, "Иван", "Тестовый", "Иванович", false, false },
                    { new Guid("081e4eb3-cbd3-422c-90d1-a9196af4754b"), "Живет где-то в Киеве", new DateTime(1988, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Киев", "Очень хороший человек", null, "Владимир", "Тестовый", "Иванович", false, false },
                    { new Guid("c5442fde-7017-4461-bab4-dc7263250bee"), "Живет где-то в Сухачевке", new DateTime(1973, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Сухачевка", "Просто хороший человек", null, "Тест", "Иванов", "Тестович", false, false }
                });
        }
    }
}
