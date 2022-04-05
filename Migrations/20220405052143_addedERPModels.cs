using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcuERP_Demo.Migrations
{
    public partial class addedERPModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AP_Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApprovedForPayment = table.Column<bool>(type: "bit", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BranchID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CashAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hold = table.Column<bool>(type: "bit", nullable: false),
                    LocationID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNbr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Terms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AP_Bills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CR_Cases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessAccount = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BusinessAccountName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CaseID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClassID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Contract = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DateReported = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OwnerEmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CR_Cases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CR_Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BusinessAccount = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContactClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Owner = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OwnerEmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParentAccount = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone1Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CR_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OP_Opportunities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BusinessAccount = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ClassID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ContactDisplayName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactID = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Estimation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OpportunityID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OwnerEmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAccount = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Stage = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OP_Opportunities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SO_SalesOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    ContactID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CustomerID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustomerOrder = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Hold = table.Column<bool>(type: "bit", nullable: false),
                    OrderedQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderNbr = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OrderType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShipToAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Totals = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SO_SalesOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SO_Shipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseCurrencyID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyRateTypeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrencyViewState = table.Column<bool>(type: "bit", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateNewShipmentForEveryOrder = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FOBPoint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverrideFreightPrice = table.Column<bool>(type: "bit", nullable: false),
                    FreightAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FreightCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FreightCurrencyID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroundCollect = table.Column<bool>(type: "bit", nullable: false),
                    Hold = table.Column<bool>(type: "bit", nullable: false),
                    Insurance = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageCount = table.Column<int>(type: "int", nullable: false),
                    PackageWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Picked = table.Column<bool>(type: "bit", nullable: false),
                    ReciprocalRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ResidentialDelivery = table.Column<bool>(type: "bit", nullable: false),
                    SaturdayDelivery = table.Column<bool>(type: "bit", nullable: false),
                    ShipmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipmentNbr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippedQty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippedVolume = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippedWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingTerms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingZoneID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipVia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToWarehouseID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseCustomersAccount = table.Column<bool>(type: "bit", nullable: false),
                    WarehouseID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkgroupID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SO_Shipments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AP_Bills");

            migrationBuilder.DropTable(
                name: "CR_Cases");

            migrationBuilder.DropTable(
                name: "CR_Contacts");

            migrationBuilder.DropTable(
                name: "OP_Opportunities");

            migrationBuilder.DropTable(
                name: "SO_SalesOrders");

            migrationBuilder.DropTable(
                name: "SO_Shipments");
        }
    }
}
