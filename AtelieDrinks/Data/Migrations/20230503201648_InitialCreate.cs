using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtelieDrinks.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Base_alcoolica",
                columns: table => new
                {
                    id_base_alcoolica = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    nome_bebida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custo_garrafa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Custo Operacional",
                columns: table => new
                {
                    id_custo_operacional = table.Column<int>(type: "int", nullable: false),
                    qtd_coordenador = table.Column<int>(type: "int", nullable: false),
                    custo_coordenador = table.Column<int>(type: "int", nullable: false),
                    qtd_profissionais_gerais = table.Column<int>(type: "int", nullable: false),
                    custo_profissionais_gerais = table.Column<decimal>(name: "custo_profissionais_gerais ", type: "decimal(18,2)", nullable: false),
                    qtd_transporte = table.Column<int>(type: "int", nullable: false),
                    custo_transporte = table.Column<int>(type: "int", nullable: false),
                    qtd_balcoes = table.Column<int>(type: "int", nullable: false),
                    custo_balcoes = table.Column<int>(type: "int", nullable: false),
                    qtd_taxa_deslocamento = table.Column<int>(type: "int", nullable: false),
                    custo_taxa_deslocamento = table.Column<int>(type: "int", nullable: false),
                    qtd_impostos_federais = table.Column<int>(type: "int", nullable: false),
                    custo_impostos_federais = table.Column<int>(type: "int", nullable: false),
                    qtd_seguro_reserva = table.Column<int>(type: "int", nullable: false),
                    custo_seguro_reserva = table.Column<int>(type: "int", nullable: false),
                    qtd_taxa_operalizacao = table.Column<int>(type: "int", nullable: false),
                    custo_taxa_operalizacao = table.Column<int>(type: "int", nullable: false),
                    custo_operacional = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Custo_deslocamento",
                columns: table => new
                {
                    id_taxa_deslocamento = table.Column<int>(type: "int", nullable: false),
                    tipo_deslocamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor_tipo_deslocamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_tipo_deslocamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Deposito",
                columns: table => new
                {
                    id_item = table.Column<int>(type: "int", nullable: false),
                    setor_armazenamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_item = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medida_de_armazenamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    custo_deposito = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    descricao_observacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    id_drink = table.Column<int>(type: "int", nullable: false),
                    nome_drink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custo_tecnico = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Ficha Tecnica",
                columns: table => new
                {
                    id_ficha = table.Column<int>(type: "int", nullable: false),
                    nome_drink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_base_alcoolica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_insumo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custo_insumo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_base_alcoolica = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    medida = table.Column<int>(type: "int", nullable: false),
                    ml_unidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_ficha = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    id_historico = table.Column<int>(type: "int", nullable: false),
                    numero_pessoas = table.Column<int>(type: "int", nullable: false),
                    custo_operacional = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_total_insumos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    base_orcamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    comisao_comercial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    comisao_gerencia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_primario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_por_pessoa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_arredondado_pra_cima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    margem_negociacao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_orcamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    previsao_lucro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    qtde_convidados = table.Column<int>(type: "int", nullable: false),
                    qtde_drinks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    id_insumo = table.Column<int>(type: "int", nullable: false),
                    nome_insumo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    custo_insumo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    id_marca = table.Column<int>(type: "int", nullable: false),
                    id_bebida = table.Column<int>(type: "int", nullable: false),
                    nome_marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome_bebida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custo_garrafa = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Orcamento",
                columns: table => new
                {
                    id_orcamento = table.Column<int>(type: "int", nullable: false),
                    numero_pessoas = table.Column<int>(type: "int", nullable: false),
                    custo_operacional = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_total_insumos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    base_orcamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    comisao_comercial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    comisao_gerencia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_primario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    custo_por_pessoa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_arredondado_pra_cima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    margem_negociacao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valor_orcamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    previsao_lucro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    qtde_convidados = table.Column<int>(type: "int", nullable: false),
                    qtde_drinks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Base_alcoolica");

            migrationBuilder.DropTable(
                name: "Custo Operacional");

            migrationBuilder.DropTable(
                name: "Custo_deslocamento");

            migrationBuilder.DropTable(
                name: "Deposito");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Ficha Tecnica");

            migrationBuilder.DropTable(
                name: "Historico");

            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Orcamento");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
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
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
        }
    }
}
