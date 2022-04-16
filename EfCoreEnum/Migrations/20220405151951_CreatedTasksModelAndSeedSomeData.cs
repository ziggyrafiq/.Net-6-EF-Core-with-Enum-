/*******************************************************************************************************************************
*  COPYRIGHT BY ZIGGY RAFIQ (ZAHEER RAFIQ)
*  LinkedIn Profile URL Address: https://www.linkedin.com/in/ziggyrafiq/ 
*
*  System   :  	Demo for Blog Post: https://blog.ziggyrafiq.com/2022/04/how-to-use-enum-data-values-with-net-60.html
*  Date     :  	16/04/2022
*  Author   :  	Ziggy Rafiq (https://www.ziggyrafiq.com)
*  License  :	MIT
*  Notes    :  	This code project is for Blog Post: How to use Enum data values with .Net 6 Framework
*
*******************************************************************************************************************************/

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnumWithEfCoreDemo.Migrations
{
    public partial class CreatedTasksModelAndSeedSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "Name", "Priority", "Status" },
                values: new object[] { new Guid("525d343f-dfd2-44fc-b1fd-ae9e7ab087cf"), "This is my 3rd Task Description", "My 3rd Task", 3, 1 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "Name", "Priority", "Status" },
                values: new object[] { new Guid("89bdf257-4e21-47c7-a92d-47efbfd1cd54"), "This is my 2nd Task Description", "My 2nd Task", 3, 3 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "Name", "Priority", "Status" },
                values: new object[] { new Guid("b4dcd04a-0572-403a-bb53-1a4dc6aa7bc2"), "This is my 1st Task Description", "My 1st Task", 3, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
