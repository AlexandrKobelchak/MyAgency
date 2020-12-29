using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "banks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    mfo = table.Column<long>(type: "bigint", nullable: false),
                    city = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "touristProfiles",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    comment = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    noSendStatus = table.Column<bool>(type: "bit", nullable: false),
                    noSendNews = table.Column<bool>(type: "bit", nullable: false),
                    city = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_touristProfiles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tours",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tours", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tourTypes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "compaties",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    address = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_compaties", x => x.id);
                    table.ForeignKey(
                        name: "FK_compaties_banks_BankId",
                        column: x => x.BankId,
                        principalTable: "banks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndividualPeople",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    passportSerial = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    passportNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    passportDistributor = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    passportMakeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    passportExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualPeople", x => x.id);
                    table.ForeignKey(
                        name: "FK_IndividualPeople_touristProfiles_id",
                        column: x => x.id,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LegalPerson",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    edrpou = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    bossName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    bossFunction = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    paymentAccount = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    bankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPerson", x => x.id);
                    table.ForeignKey(
                        name: "FK_LegalPerson_banks_bankId",
                        column: x => x.bankId,
                        principalTable: "banks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LegalPerson_touristProfiles_id",
                        column: x => x.id,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "touristPhones",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    sendSMS = table.Column<bool>(type: "bit", nullable: false),
                    touristId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_touristPhones", x => x.id);
                    table.ForeignKey(
                        name: "FK_touristPhones_touristProfiles_touristId",
                        column: x => x.touristId,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tourists_tags",
                columns: table => new
                {
                    touristId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tourists_tags", x => new { x.tagId, x.touristId });
                    table.ForeignKey(
                        name: "FK_tourists_tags_tags_tagId",
                        column: x => x.tagId,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tourists_tags_touristProfiles_touristId",
                        column: x => x.touristId,
                        principalTable: "touristProfiles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tours_countries",
                columns: table => new
                {
                    countryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tours_countries", x => new { x.tourId, x.countryId });
                    table.ForeignKey(
                        name: "FK_tours_countries_countries_countryId",
                        column: x => x.countryId,
                        principalTable: "countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tours_countries_tours_tourId",
                        column: x => x.tourId,
                        principalTable: "tours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tours_ tourTypes",
                columns: table => new
                {
                    tourTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tours_ tourTypes", x => new { x.tourId, x.tourTypeId });
                    table.ForeignKey(
                        name: "FK_tours_ tourTypes_tours_tourId",
                        column: x => x.tourId,
                        principalTable: "tours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tours_ tourTypes_tourTypes_tourTypeId",
                        column: x => x.tourTypeId,
                        principalTable: "tourTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    companyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_compaties_companyId",
                        column: x => x.companyId,
                        principalTable: "compaties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_compaties_BankId",
                table: "compaties",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_companyId",
                table: "Employees",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalPerson_bankId",
                table: "LegalPerson",
                column: "bankId");

            migrationBuilder.CreateIndex(
                name: "IX_touristPhones_touristId",
                table: "touristPhones",
                column: "touristId");

            migrationBuilder.CreateIndex(
                name: "IX_tourists_tags_touristId",
                table: "tourists_tags",
                column: "touristId");

            migrationBuilder.CreateIndex(
                name: "IX_tours_ tourTypes_tourTypeId",
                table: "tours_ tourTypes",
                column: "tourTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tours_countries_countryId",
                table: "tours_countries",
                column: "countryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "IndividualPeople");

            migrationBuilder.DropTable(
                name: "LegalPerson");

            migrationBuilder.DropTable(
                name: "touristPhones");

            migrationBuilder.DropTable(
                name: "tourists_tags");

            migrationBuilder.DropTable(
                name: "tours_ tourTypes");

            migrationBuilder.DropTable(
                name: "tours_countries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "compaties");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "touristProfiles");

            migrationBuilder.DropTable(
                name: "tourTypes");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "tours");

            migrationBuilder.DropTable(
                name: "banks");
        }
    }
}
