using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TNRD.Zeepkist.GTR.Database.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:fuzzystrmatch", ",,")
                .Annotation("Npgsql:PostgresExtension:postgis", ",,")
                .Annotation("Npgsql:PostgresExtension:tiger.postgis_tiger_geocoder", ",,")
                .Annotation("Npgsql:PostgresExtension:topology.postgis_topology", ",,");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    steam_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    steam_name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    discord_id = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    banned = table.Column<bool>(type: "boolean", nullable: false, defaultValueSql: "false"),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "versions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    minimum = table.Column<string>(type: "text", nullable: true),
                    latest = table.Column<string>(type: "text", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("versions_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "auth",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user = table.Column<int>(type: "integer", nullable: true),
                    access_token = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    access_token_expiry = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    refresh_token = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    refresh_token_expiry = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    type = table.Column<int>(type: "integer", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("auth_pkey", x => x.id);
                    table.ForeignKey(
                        name: "auth_user_foreign",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                },
                comment: "@omit");

            migrationBuilder.CreateTable(
                name: "favorites",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("favorites_pkey", x => x.id);
                    table.ForeignKey(
                        name: "favorites_user_foreign",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "records",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user = table.Column<int>(type: "integer", nullable: false),
                    time = table.Column<float>(type: "real", nullable: false),
                    splits = table.Column<string>(type: "text", nullable: true),
                    game_version = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    is_valid = table.Column<bool>(type: "boolean", nullable: false),
                    level = table.Column<string>(type: "text", nullable: false),
                    mod_version = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("records_pkey", x => x.id);
                    table.ForeignKey(
                        name: "records_user_foreign",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "stats",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    crash_total = table.Column<int>(type: "integer", nullable: false),
                    crash_regular = table.Column<int>(type: "integer", nullable: false),
                    crash_eye = table.Column<int>(type: "integer", nullable: false),
                    crash_ghost = table.Column<int>(type: "integer", nullable: false),
                    crash_sticky = table.Column<int>(type: "integer", nullable: false),
                    distance_arms_up = table.Column<float>(type: "real", nullable: false),
                    distance_braking = table.Column<float>(type: "real", nullable: false),
                    distance_grounded = table.Column<float>(type: "real", nullable: false),
                    distance_in_air = table.Column<float>(type: "real", nullable: false),
                    distance_on_no_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_on_one_wheel = table.Column<float>(type: "real", nullable: false),
                    distance_on_two_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_on_three_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_on_four_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_ragdoll = table.Column<float>(type: "real", nullable: false),
                    distance_with_no_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_with_one_wheel = table.Column<float>(type: "real", nullable: false),
                    distance_with_two_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_with_three_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_with_four_wheels = table.Column<float>(type: "real", nullable: false),
                    distance_on_regular = table.Column<float>(type: "real", nullable: false),
                    distance_on_grass = table.Column<float>(type: "real", nullable: false),
                    distance_on_ice = table.Column<float>(type: "real", nullable: false),
                    time_arms_up = table.Column<float>(type: "real", nullable: false),
                    time_braking = table.Column<float>(type: "real", nullable: false),
                    time_grounded = table.Column<float>(type: "real", nullable: false),
                    time_in_air = table.Column<float>(type: "real", nullable: false),
                    time_on_no_wheels = table.Column<float>(type: "real", nullable: false),
                    time_on_one_wheel = table.Column<float>(type: "real", nullable: false),
                    time_on_two_wheels = table.Column<float>(type: "real", nullable: false),
                    time_on_three_wheels = table.Column<float>(type: "real", nullable: false),
                    time_on_four_wheels = table.Column<float>(type: "real", nullable: false),
                    time_ragdoll = table.Column<float>(type: "real", nullable: false),
                    time_with_no_wheels = table.Column<float>(type: "real", nullable: false),
                    time_with_one_wheel = table.Column<float>(type: "real", nullable: false),
                    time_with_two_wheels = table.Column<float>(type: "real", nullable: false),
                    time_with_three_wheels = table.Column<float>(type: "real", nullable: false),
                    time_with_four_wheels = table.Column<float>(type: "real", nullable: false),
                    time_on_regular = table.Column<float>(type: "real", nullable: false),
                    time_on_grass = table.Column<float>(type: "real", nullable: false),
                    time_on_ice = table.Column<float>(type: "real", nullable: false),
                    times_started = table.Column<int>(type: "integer", nullable: false),
                    times_finished = table.Column<int>(type: "integer", nullable: false),
                    wheels_broken = table.Column<int>(type: "integer", nullable: false),
                    checkpoints_crossed = table.Column<int>(type: "integer", nullable: false),
                    user = table.Column<int>(type: "integer", nullable: false),
                    month = table.Column<int>(type: "integer", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("stats_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fk_user_id",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "upvotes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("upvotes_pkey", x => x.id);
                    table.ForeignKey(
                        name: "upvotes_user_foreign",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "votes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user = table.Column<int>(type: "integer", nullable: false),
                    score = table.Column<int>(type: "integer", nullable: false),
                    category = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("votes_pkey", x => x.id);
                    table.ForeignKey(
                        name: "votes_user_foreign",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "media",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    record = table.Column<int>(type: "integer", nullable: false),
                    ghost_url = table.Column<string>(type: "text", nullable: false),
                    screenshot_url = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("media_pkey", x => x.id);
                    table.ForeignKey(
                        name: "media_record_fkey",
                        column: x => x.record,
                        principalTable: "records",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "personal_bests",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    record = table.Column<int>(type: "integer", nullable: false),
                    user = table.Column<int>(type: "integer", nullable: false),
                    period_start = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    period_end = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    level = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("personal_bests_pkey", x => x.id);
                    table.ForeignKey(
                        name: "personal_bests_record_fkey",
                        column: x => x.record,
                        principalTable: "records",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "personal_bests_user_fkey",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "world_records",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    record = table.Column<int>(type: "integer", nullable: false),
                    user = table.Column<int>(type: "integer", nullable: false),
                    period_start = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    period_end = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    level = table.Column<string>(type: "text", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()"),
                    date_updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql:"now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("world_records_pkey", x => x.id);
                    table.ForeignKey(
                        name: "world_records_record_fkey",
                        column: x => x.record,
                        principalTable: "records",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "world_records_user_fkey",
                        column: x => x.user,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_auth_user",
                table: "auth",
                column: "user");

            migrationBuilder.CreateIndex(
                name: "IX_favorites_user",
                table: "favorites",
                column: "user");

            migrationBuilder.CreateIndex(
                name: "IX_media_record",
                table: "media",
                column: "record");

            migrationBuilder.CreateIndex(
                name: "IX_personal_bests_record",
                table: "personal_bests",
                column: "record");

            migrationBuilder.CreateIndex(
                name: "IX_personal_bests_user",
                table: "personal_bests",
                column: "user");

            migrationBuilder.CreateIndex(
                name: "IX_records_user",
                table: "records",
                column: "user");

            migrationBuilder.CreateIndex(
                name: "IX_stats_user",
                table: "stats",
                column: "user");

            migrationBuilder.CreateIndex(
                name: "IX_upvotes_user",
                table: "upvotes",
                column: "user");

            migrationBuilder.CreateIndex(
                name: "IX_votes_user",
                table: "votes",
                column: "user");

            migrationBuilder.CreateIndex(
                name: "IX_world_records_record",
                table: "world_records",
                column: "record");

            migrationBuilder.CreateIndex(
                name: "IX_world_records_user",
                table: "world_records",
                column: "user");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "auth");

            migrationBuilder.DropTable(
                name: "favorites");

            migrationBuilder.DropTable(
                name: "media");

            migrationBuilder.DropTable(
                name: "personal_bests");

            migrationBuilder.DropTable(
                name: "stats");

            migrationBuilder.DropTable(
                name: "upvotes");

            migrationBuilder.DropTable(
                name: "versions");

            migrationBuilder.DropTable(
                name: "votes");

            migrationBuilder.DropTable(
                name: "world_records");

            migrationBuilder.DropTable(
                name: "records");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
