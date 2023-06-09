﻿// <auto-generated />
using System;
using ChatMe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChatMe.Migrations
{
    [DbContext(typeof(ChatContext))]
    [Migration("20220209180745_testEnv")]
    partial class testEnv
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChatMe.Models.Chat", b =>
                {
                    b.Property<int>("chatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("chatColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chatName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isGroupMessage")
                        .HasColumnType("bit");

                    b.Property<DateTime>("lastMessageTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("usersIDs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("chatID");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("ChatMe.Models.Message", b =>
                {
                    b.Property<int>("messageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("chatID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("creatorID")
                        .HasColumnType("int");

                    b.Property<string>("messageContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("messageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ChatMe.Models.Readed", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("messageID")
                        .HasColumnType("int");

                    b.Property<DateTime>("readTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("messageID");

                    b.ToTable("Readed");
                });

            modelBuilder.Entity("ChatMe.Models.Settings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("darkMode")
                        .HasColumnType("bit");

                    b.Property<int>("userID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("ChatMe.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("about")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("displayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("expire")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("lastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ChatMe.Models.Readed", b =>
                {
                    b.HasOne("ChatMe.Models.Message", null)
                        .WithMany("readedBy")
                        .HasForeignKey("messageID");
                });
#pragma warning restore 612, 618
        }
    }
}
