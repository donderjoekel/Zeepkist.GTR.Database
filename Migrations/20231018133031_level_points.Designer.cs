﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TNRD.Zeepkist.GTR.Database;

#nullable disable

namespace TNRD.Zeepkist.GTR.Database.Migrations
{
    [DbContext(typeof(GTRContext))]
    [Migration("20231018133031_level_points")]
    partial class level_points
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "fuzzystrmatch");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "postgis");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "tiger", "postgis_tiger_geocoder");
            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "topology", "postgis_topology");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Auth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessToken")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("access_token");

                    b.Property<string>("AccessTokenExpiry")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("access_token_expiry");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("refresh_token");

                    b.Property<string>("RefreshTokenExpiry")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("refresh_token_expiry");

                    b.Property<int?>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.Property<int?>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("auth_pkey");

                    b.HasIndex("User");

                    b.ToTable("auth", null, t =>
                        {
                            t.HasComment("@omit");
                        });
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("level");

                    b.Property<int>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("favorites_pkey");

                    b.HasIndex("User");

                    b.ToTable("favorites");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.LevelPoints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("level");

                    b.Property<int>("Points")
                        .HasColumnType("integer")
                        .HasColumnName("points");

                    b.HasKey("Id")
                        .HasName("level_points_pkey");

                    b.ToTable("level_points");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("GhostUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ghost_url");

                    b.Property<int>("Record")
                        .HasColumnType("integer")
                        .HasColumnName("record");

                    b.Property<string>("ScreenshotUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("screenshot_url");

                    b.HasKey("Id")
                        .HasName("media_pkey");

                    b.HasIndex("Record");

                    b.ToTable("media");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.PersonalBest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("level");

                    b.Property<DateTime?>("PeriodEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("period_end");

                    b.Property<DateTime?>("PeriodStart")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("period_start");

                    b.Property<int>("Record")
                        .HasColumnType("integer")
                        .HasColumnName("record");

                    b.Property<int>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("personal_bests_pkey");

                    b.HasIndex("Record");

                    b.HasIndex("User");

                    b.ToTable("personal_bests");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("GameVersion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("game_version");

                    b.Property<bool>("IsValid")
                        .HasColumnType("boolean")
                        .HasColumnName("is_valid");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("level");

                    b.Property<string>("ModVersion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("mod_version");

                    b.Property<string>("Splits")
                        .HasColumnType("text")
                        .HasColumnName("splits");

                    b.Property<float>("Time")
                        .HasColumnType("real")
                        .HasColumnName("time");

                    b.Property<int>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("records_pkey");

                    b.HasIndex("User");

                    b.ToTable("records");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Stat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<int>("CheckpointsCrossed")
                        .HasColumnType("integer")
                        .HasColumnName("checkpoints_crossed");

                    b.Property<int>("CrashEye")
                        .HasColumnType("integer")
                        .HasColumnName("crash_eye");

                    b.Property<int>("CrashGhost")
                        .HasColumnType("integer")
                        .HasColumnName("crash_ghost");

                    b.Property<int>("CrashRegular")
                        .HasColumnType("integer")
                        .HasColumnName("crash_regular");

                    b.Property<int>("CrashSticky")
                        .HasColumnType("integer")
                        .HasColumnName("crash_sticky");

                    b.Property<int>("CrashTotal")
                        .HasColumnType("integer")
                        .HasColumnName("crash_total");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<float>("DistanceArmsUp")
                        .HasColumnType("real")
                        .HasColumnName("distance_arms_up");

                    b.Property<float>("DistanceBraking")
                        .HasColumnType("real")
                        .HasColumnName("distance_braking");

                    b.Property<float>("DistanceGrounded")
                        .HasColumnType("real")
                        .HasColumnName("distance_grounded");

                    b.Property<float>("DistanceInAir")
                        .HasColumnType("real")
                        .HasColumnName("distance_in_air");

                    b.Property<float>("DistanceOnFourWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_four_wheels");

                    b.Property<float>("DistanceOnGrass")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_grass");

                    b.Property<float>("DistanceOnIce")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_ice");

                    b.Property<float>("DistanceOnNoWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_no_wheels");

                    b.Property<float>("DistanceOnOneWheel")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_one_wheel");

                    b.Property<float>("DistanceOnRegular")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_regular");

                    b.Property<float>("DistanceOnThreeWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_three_wheels");

                    b.Property<float>("DistanceOnTwoWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_on_two_wheels");

                    b.Property<float>("DistanceRagdoll")
                        .HasColumnType("real")
                        .HasColumnName("distance_ragdoll");

                    b.Property<float>("DistanceWithFourWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_with_four_wheels");

                    b.Property<float>("DistanceWithNoWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_with_no_wheels");

                    b.Property<float>("DistanceWithOneWheel")
                        .HasColumnType("real")
                        .HasColumnName("distance_with_one_wheel");

                    b.Property<float>("DistanceWithThreeWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_with_three_wheels");

                    b.Property<float>("DistanceWithTwoWheels")
                        .HasColumnType("real")
                        .HasColumnName("distance_with_two_wheels");

                    b.Property<int>("Month")
                        .HasColumnType("integer")
                        .HasColumnName("month");

                    b.Property<float>("TimeArmsUp")
                        .HasColumnType("real")
                        .HasColumnName("time_arms_up");

                    b.Property<float>("TimeBraking")
                        .HasColumnType("real")
                        .HasColumnName("time_braking");

                    b.Property<float>("TimeGrounded")
                        .HasColumnType("real")
                        .HasColumnName("time_grounded");

                    b.Property<float>("TimeInAir")
                        .HasColumnType("real")
                        .HasColumnName("time_in_air");

                    b.Property<float>("TimeOnFourWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_on_four_wheels");

                    b.Property<float>("TimeOnGrass")
                        .HasColumnType("real")
                        .HasColumnName("time_on_grass");

                    b.Property<float>("TimeOnIce")
                        .HasColumnType("real")
                        .HasColumnName("time_on_ice");

                    b.Property<float>("TimeOnNoWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_on_no_wheels");

                    b.Property<float>("TimeOnOneWheel")
                        .HasColumnType("real")
                        .HasColumnName("time_on_one_wheel");

                    b.Property<float>("TimeOnRegular")
                        .HasColumnType("real")
                        .HasColumnName("time_on_regular");

                    b.Property<float>("TimeOnThreeWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_on_three_wheels");

                    b.Property<float>("TimeOnTwoWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_on_two_wheels");

                    b.Property<float>("TimeRagdoll")
                        .HasColumnType("real")
                        .HasColumnName("time_ragdoll");

                    b.Property<float>("TimeWithFourWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_with_four_wheels");

                    b.Property<float>("TimeWithNoWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_with_no_wheels");

                    b.Property<float>("TimeWithOneWheel")
                        .HasColumnType("real")
                        .HasColumnName("time_with_one_wheel");

                    b.Property<float>("TimeWithThreeWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_with_three_wheels");

                    b.Property<float>("TimeWithTwoWheels")
                        .HasColumnType("real")
                        .HasColumnName("time_with_two_wheels");

                    b.Property<int>("TimesFinished")
                        .HasColumnType("integer")
                        .HasColumnName("times_finished");

                    b.Property<int>("TimesStarted")
                        .HasColumnType("integer")
                        .HasColumnName("times_started");

                    b.Property<int>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.Property<int>("WheelsBroken")
                        .HasColumnType("integer")
                        .HasColumnName("wheels_broken");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("Id")
                        .HasName("stats_pkey");

                    b.HasIndex("User");

                    b.ToTable("stats");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Upvote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("level");

                    b.Property<int>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("upvotes_pkey");

                    b.HasIndex("User");

                    b.ToTable("upvotes");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Banned")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasColumnName("banned")
                        .HasDefaultValueSql("false");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("DiscordId")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("discord_id");

                    b.Property<string>("SteamId")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("steam_id");

                    b.Property<string>("SteamName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("steam_name");

                    b.HasKey("Id")
                        .HasName("users_pkey");

                    b.ToTable("users");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Version", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("Latest")
                        .HasColumnType("text")
                        .HasColumnName("latest");

                    b.Property<string>("Minimum")
                        .HasColumnType("text")
                        .HasColumnName("minimum");

                    b.HasKey("Id")
                        .HasName("versions_pkey");

                    b.ToTable("versions");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("level");

                    b.Property<int>("Score")
                        .HasColumnType("integer")
                        .HasColumnName("score");

                    b.Property<int>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("votes_pkey");

                    b.HasIndex("User");

                    b.ToTable("votes");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.WorldRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTime>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_updated");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("level");

                    b.Property<DateTime?>("PeriodEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("period_end");

                    b.Property<DateTime?>("PeriodStart")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("period_start");

                    b.Property<int>("Record")
                        .HasColumnType("integer")
                        .HasColumnName("record");

                    b.Property<int>("User")
                        .HasColumnType("integer")
                        .HasColumnName("user");

                    b.HasKey("Id")
                        .HasName("world_records_pkey");

                    b.HasIndex("Record");

                    b.HasIndex("User");

                    b.ToTable("world_records");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Auth", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("Auths")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("auth_user_foreign");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Favorite", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("Favorites")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired()
                        .HasConstraintName("favorites_user_foreign");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Media", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.Record", "RecordNavigation")
                        .WithMany("Media")
                        .HasForeignKey("Record")
                        .IsRequired()
                        .HasConstraintName("media_record_fkey");

                    b.Navigation("RecordNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.PersonalBest", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.Record", "RecordNavigation")
                        .WithMany("PersonalBests")
                        .HasForeignKey("Record")
                        .IsRequired()
                        .HasConstraintName("personal_bests_record_fkey");

                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("PersonalBests")
                        .HasForeignKey("User")
                        .IsRequired()
                        .HasConstraintName("personal_bests_user_fkey");

                    b.Navigation("RecordNavigation");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Record", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("Records")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired()
                        .HasConstraintName("records_user_foreign");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Stat", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("Stats")
                        .HasForeignKey("User")
                        .IsRequired()
                        .HasConstraintName("fk_user_id");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Upvote", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("Upvotes")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired()
                        .HasConstraintName("upvotes_user_foreign");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Vote", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("Votes")
                        .HasForeignKey("User")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired()
                        .HasConstraintName("votes_user_foreign");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.WorldRecord", b =>
                {
                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.Record", "RecordNavigation")
                        .WithMany("WorldRecords")
                        .HasForeignKey("Record")
                        .IsRequired()
                        .HasConstraintName("world_records_record_fkey");

                    b.HasOne("TNRD.Zeepkist.GTR.Database.Models.User", "UserNavigation")
                        .WithMany("WorldRecordsNavigation")
                        .HasForeignKey("User")
                        .IsRequired()
                        .HasConstraintName("world_records_user_fkey");

                    b.Navigation("RecordNavigation");

                    b.Navigation("UserNavigation");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.Record", b =>
                {
                    b.Navigation("Media");

                    b.Navigation("PersonalBests");

                    b.Navigation("WorldRecords");
                });

            modelBuilder.Entity("TNRD.Zeepkist.GTR.Database.Models.User", b =>
                {
                    b.Navigation("Auths");

                    b.Navigation("Favorites");

                    b.Navigation("PersonalBests");

                    b.Navigation("Records");

                    b.Navigation("Stats");

                    b.Navigation("Upvotes");

                    b.Navigation("Votes");

                    b.Navigation("WorldRecordsNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}