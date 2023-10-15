using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreCompiledModels.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs001",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs001", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs002",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs002", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs003",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs003", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs004",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs004", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs005",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs005", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs006",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs006", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs007",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs007", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs008",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs008", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs009",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs009", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs010",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs010", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs011",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs011", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs012",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs012", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs013",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs013", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs014",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs014", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs015",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs015", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs016",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs016", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs017",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs017", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs018",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs018", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs019",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs019", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs020",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs020", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts001",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts001", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts001_Blogs001_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs001",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts002",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts002", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts002_Blogs002_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs002",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts003",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts003", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts003_Blogs003_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs003",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts004",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts004", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts004_Blogs004_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs004",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts005",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts005", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts005_Blogs005_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs005",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts006",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts006", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts006_Blogs006_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs006",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts007",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts007", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts007_Blogs007_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs007",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts008",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts008", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts008_Blogs008_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs008",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts009",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts009", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts009_Blogs009_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs009",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts010",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts010", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts010_Blogs010_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs010",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts011",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts011", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts011_Blogs011_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs011",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts012",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts012", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts012_Blogs012_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs012",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts013",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts013", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts013_Blogs013_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs013",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts014",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts014", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts014_Blogs014_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs014",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts015",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts015", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts015_Blogs015_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs015",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts016",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts016", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts016_Blogs016_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs016",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts017",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts017", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts017_Blogs017_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs017",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts018",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts018", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts018_Blogs018_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs018",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts019",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts019", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts019_Blogs019_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs019",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts020",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts020", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts020_Blogs020_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs020",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts001_BlogId",
                table: "Posts001",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts002_BlogId",
                table: "Posts002",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts003_BlogId",
                table: "Posts003",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts004_BlogId",
                table: "Posts004",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts005_BlogId",
                table: "Posts005",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts006_BlogId",
                table: "Posts006",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts007_BlogId",
                table: "Posts007",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts008_BlogId",
                table: "Posts008",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts009_BlogId",
                table: "Posts009",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts010_BlogId",
                table: "Posts010",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts011_BlogId",
                table: "Posts011",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts012_BlogId",
                table: "Posts012",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts013_BlogId",
                table: "Posts013",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts014_BlogId",
                table: "Posts014",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts015_BlogId",
                table: "Posts015",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts016_BlogId",
                table: "Posts016",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts017_BlogId",
                table: "Posts017",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts018_BlogId",
                table: "Posts018",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts019_BlogId",
                table: "Posts019",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts020_BlogId",
                table: "Posts020",
                column: "BlogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts001");

            migrationBuilder.DropTable(
                name: "Posts002");

            migrationBuilder.DropTable(
                name: "Posts003");

            migrationBuilder.DropTable(
                name: "Posts004");

            migrationBuilder.DropTable(
                name: "Posts005");

            migrationBuilder.DropTable(
                name: "Posts006");

            migrationBuilder.DropTable(
                name: "Posts007");

            migrationBuilder.DropTable(
                name: "Posts008");

            migrationBuilder.DropTable(
                name: "Posts009");

            migrationBuilder.DropTable(
                name: "Posts010");

            migrationBuilder.DropTable(
                name: "Posts011");

            migrationBuilder.DropTable(
                name: "Posts012");

            migrationBuilder.DropTable(
                name: "Posts013");

            migrationBuilder.DropTable(
                name: "Posts014");

            migrationBuilder.DropTable(
                name: "Posts015");

            migrationBuilder.DropTable(
                name: "Posts016");

            migrationBuilder.DropTable(
                name: "Posts017");

            migrationBuilder.DropTable(
                name: "Posts018");

            migrationBuilder.DropTable(
                name: "Posts019");

            migrationBuilder.DropTable(
                name: "Posts020");

            migrationBuilder.DropTable(
                name: "Blogs001");

            migrationBuilder.DropTable(
                name: "Blogs002");

            migrationBuilder.DropTable(
                name: "Blogs003");

            migrationBuilder.DropTable(
                name: "Blogs004");

            migrationBuilder.DropTable(
                name: "Blogs005");

            migrationBuilder.DropTable(
                name: "Blogs006");

            migrationBuilder.DropTable(
                name: "Blogs007");

            migrationBuilder.DropTable(
                name: "Blogs008");

            migrationBuilder.DropTable(
                name: "Blogs009");

            migrationBuilder.DropTable(
                name: "Blogs010");

            migrationBuilder.DropTable(
                name: "Blogs011");

            migrationBuilder.DropTable(
                name: "Blogs012");

            migrationBuilder.DropTable(
                name: "Blogs013");

            migrationBuilder.DropTable(
                name: "Blogs014");

            migrationBuilder.DropTable(
                name: "Blogs015");

            migrationBuilder.DropTable(
                name: "Blogs016");

            migrationBuilder.DropTable(
                name: "Blogs017");

            migrationBuilder.DropTable(
                name: "Blogs018");

            migrationBuilder.DropTable(
                name: "Blogs019");

            migrationBuilder.DropTable(
                name: "Blogs020");
        }
    }
}
