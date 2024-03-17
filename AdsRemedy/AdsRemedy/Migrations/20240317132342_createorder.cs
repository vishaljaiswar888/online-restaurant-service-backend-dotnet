using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdsRemedy.Migrations
{
    public partial class createorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateOrders",
                columns: table => new
                {
                    CO_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CO_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CO_Qty = table.Column<int>(type: "int", nullable: true),
                    CO_Size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateOrders", x => x.CO_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateOrders");
        }
    }
}
