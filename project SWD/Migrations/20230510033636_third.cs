using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project_SWD.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    category_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.category_ID);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    customer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.customer_ID);
                });

            migrationBuilder.CreateTable(
                name: "sellers",
                columns: table => new
                {
                    seller_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seller_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellers", x => x.seller_ID);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    payment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_ID2 = table.Column<int>(type: "int", nullable: false),
                    payment_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customer_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.payment_ID);
                    table.ForeignKey(
                        name: "FK_payments_customers_customer_ID",
                        column: x => x.customer_ID,
                        principalTable: "customers",
                        principalColumn: "customer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "shopping_Orders",
                columns: table => new
                {
                    order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerID = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopping_Orders", x => x.order_ID);
                    table.ForeignKey(
                        name: "FK_shopping_Orders_customers_customerID",
                        column: x => x.customerID,
                        principalTable: "customers",
                        principalColumn: "customer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_price = table.Column<int>(type: "int", nullable: false),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryID = table.Column<int>(type: "int", nullable: false),
                    sellerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.product_ID);
                    table.ForeignKey(
                        name: "FK_products_categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "categories",
                        principalColumn: "category_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_sellers_sellerID",
                        column: x => x.sellerID,
                        principalTable: "sellers",
                        principalColumn: "seller_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    report_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_ID4 = table.Column<int>(type: "int", nullable: false),
                    order_ID4 = table.Column<int>(type: "int", nullable: false),
                    payment_ID4 = table.Column<int>(type: "int", nullable: false),
                    total_cost = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customer_ID = table.Column<int>(type: "int", nullable: false),
                    payment_ID = table.Column<int>(type: "int", nullable: false),
                    Shopping_Orderorder_ID = table.Column<int>(type: "int", nullable: false),
                    product_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.report_ID);
                    table.ForeignKey(
                        name: "FK_comments_customers_customer_ID",
                        column: x => x.customer_ID,
                        principalTable: "customers",
                        principalColumn: "customer_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comments_payments_payment_ID",
                        column: x => x.payment_ID,
                        principalTable: "payments",
                        principalColumn: "payment_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_comments_products_product_ID",
                        column: x => x.product_ID,
                        principalTable: "products",
                        principalColumn: "product_ID");
                    table.ForeignKey(
                        name: "FK_comments_shopping_Orders_Shopping_Orderorder_ID",
                        column: x => x.Shopping_Orderorder_ID,
                        principalTable: "shopping_Orders",
                        principalColumn: "order_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "order_context",
                columns: table => new
                {
                    delivery_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_ID1 = table.Column<int>(type: "int", nullable: false),
                    customer_ID1 = table.Column<int>(type: "int", nullable: false),
                    product_ID1 = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    product_ID = table.Column<int>(type: "int", nullable: false),
                    Shopping_Orderorder_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_context", x => x.delivery_ID);
                    table.ForeignKey(
                        name: "FK_order_context_products_product_ID",
                        column: x => x.product_ID,
                        principalTable: "products",
                        principalColumn: "product_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_context_shopping_Orders_Shopping_Orderorder_ID",
                        column: x => x.Shopping_Orderorder_ID,
                        principalTable: "shopping_Orders",
                        principalColumn: "order_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_contextpayment",
                columns: table => new
                {
                    Order_Contextsdelivery_ID = table.Column<int>(type: "int", nullable: false),
                    Paymentspayment_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_contextpayment", x => new { x.Order_Contextsdelivery_ID, x.Paymentspayment_ID });
                    table.ForeignKey(
                        name: "FK_order_contextpayment_order_context_Order_Contextsdelivery_ID",
                        column: x => x.Order_Contextsdelivery_ID,
                        principalTable: "order_context",
                        principalColumn: "delivery_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_contextpayment_payments_Paymentspayment_ID",
                        column: x => x.Paymentspayment_ID,
                        principalTable: "payments",
                        principalColumn: "payment_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_customer_ID",
                table: "comments",
                column: "customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_payment_ID",
                table: "comments",
                column: "payment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_product_ID",
                table: "comments",
                column: "product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_Shopping_Orderorder_ID",
                table: "comments",
                column: "Shopping_Orderorder_ID");

            migrationBuilder.CreateIndex(
                name: "IX_order_context_product_ID",
                table: "order_context",
                column: "product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_order_context_Shopping_Orderorder_ID",
                table: "order_context",
                column: "Shopping_Orderorder_ID");

            migrationBuilder.CreateIndex(
                name: "IX_order_contextpayment_Paymentspayment_ID",
                table: "order_contextpayment",
                column: "Paymentspayment_ID");

            migrationBuilder.CreateIndex(
                name: "IX_payments_customer_ID",
                table: "payments",
                column: "customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryID",
                table: "products",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_products_sellerID",
                table: "products",
                column: "sellerID");

            migrationBuilder.CreateIndex(
                name: "IX_shopping_Orders_customerID",
                table: "shopping_Orders",
                column: "customerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "order_contextpayment");

            migrationBuilder.DropTable(
                name: "order_context");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "shopping_Orders");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "sellers");

            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
