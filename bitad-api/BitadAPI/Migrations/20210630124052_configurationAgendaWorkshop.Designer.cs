﻿// <auto-generated />
using System;
using BitadAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BitadAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210630124052_configurationAgendaWorkshop")]
    partial class configurationAgendaWorkshop
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BitadAPI.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp")
                        .HasColumnName("end");

                    b.Property<string>("Room")
                        .HasColumnType("text")
                        .HasColumnName("room");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp")
                        .HasColumnName("start");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at");

                    b.Property<int?>("speaker_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("speaker_id");

                    b.ToTable("agendas");
                });

            modelBuilder.Entity("BitadAPI.Models.QrCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("ActivationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValue(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc))
                        .HasColumnName("activation_time");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<DateTime>("DeactivationTime")
                        .HasColumnType("timestamp")
                        .HasColumnName("deactivation_time");

                    b.Property<int>("Points")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("points");

                    b.HasKey("Id");

                    b.ToTable("qr_codes");
                });

            modelBuilder.Entity("BitadAPI.Models.QrCodeRedeem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("RedeemTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("redeem_time");

                    b.Property<int>("qr_code_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("qr_code_id");

                    b.HasIndex("user_id");

                    b.ToTable("qr_code_reedeems");
                });

            modelBuilder.Entity("BitadAPI.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Company")
                        .HasColumnType("text")
                        .HasColumnName("company");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Picture")
                        .HasColumnType("text")
                        .HasColumnName("picture");

                    b.Property<string>("Website")
                        .HasColumnType("text")
                        .HasColumnName("website");

                    b.Property<string>("WebsiteLink")
                        .HasColumnType("text")
                        .HasColumnName("website_link");

                    b.HasKey("Id");

                    b.ToTable("speakers");
                });

            modelBuilder.Entity("BitadAPI.Models.Sponsor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Picture")
                        .HasColumnType("text")
                        .HasColumnName("picture");

                    b.Property<int>("Rank")
                        .HasColumnType("int")
                        .HasColumnName("rank");

                    b.Property<string>("Webpage")
                        .HasColumnType("text")
                        .HasColumnName("website");

                    b.HasKey("Id");

                    b.ToTable("sponsors");
                });

            modelBuilder.Entity("BitadAPI.Models.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Picture")
                        .HasColumnType("text")
                        .HasColumnName("picture");

                    b.HasKey("Id");

                    b.ToTable("staff");
                });

            modelBuilder.Entity("BitadAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CurrentJwt")
                        .HasColumnType("text")
                        .HasColumnName("current_jwt");

                    b.Property<int>("CurrentScore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("current_score");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_salt");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.Property<int?>("workshop_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("workshop_id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("BitadAPI.Models.Workshop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp")
                        .HasColumnName("end");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("int")
                        .HasColumnName("max_participants");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("room");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp")
                        .HasColumnName("start");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<int>("speaker_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("speaker_id");

                    b.ToTable("workshops");
                });

            modelBuilder.Entity("BitadAPI.Models.Agenda", b =>
                {
                    b.HasOne("BitadAPI.Models.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("speaker_id");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("BitadAPI.Models.QrCodeRedeem", b =>
                {
                    b.HasOne("BitadAPI.Models.QrCode", "QrCode")
                        .WithMany()
                        .HasForeignKey("qr_code_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BitadAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QrCode");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BitadAPI.Models.User", b =>
                {
                    b.HasOne("BitadAPI.Models.Workshop", "Workshop")
                        .WithMany("Participants")
                        .HasForeignKey("workshop_id");

                    b.Navigation("Workshop");
                });

            modelBuilder.Entity("BitadAPI.Models.Workshop", b =>
                {
                    b.HasOne("BitadAPI.Models.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("speaker_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("BitadAPI.Models.Workshop", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
