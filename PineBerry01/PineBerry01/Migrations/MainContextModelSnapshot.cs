﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PineBerry01.DataContext;

namespace PineBerry01.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PineBerry01.Models.Berry", b =>
                {
                    b.Property<int>("BerryNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BerryContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BerrySubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BerryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BerryNo");

                    b.HasIndex("BerrySubjectName");

                    b.ToTable("Berries");
                });

            modelBuilder.Entity("PineBerry01.Models.BerrySubject", b =>
                {
                    b.Property<string>("BerrySubjectName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BerrySubjectName");

                    b.ToTable("BerrySubjects");
                });

            modelBuilder.Entity("PineBerry01.Models.BerrySuggest", b =>
                {
                    b.Property<int>("BerrySuggestKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SuggestContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SuggestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SuggestTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BerrySuggestKey");

                    b.ToTable("BerrySuggests");
                });

            modelBuilder.Entity("PineBerry01.Models.Notice", b =>
                {
                    b.Property<int>("NoticeNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NoticeContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoticeTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoticeNo");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("PineBerry01.Models.QnASubject", b =>
                {
                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Subject");

                    b.ToTable("QnASubjects");
                });

            modelBuilder.Entity("PineBerry01.Models.User", b =>
                {
                    b.Property<int>("UserNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserNo");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PineBerry01.Models.Berry", b =>
                {
                    b.HasOne("PineBerry01.Models.BerrySubject", "berrySubject")
                        .WithMany()
                        .HasForeignKey("BerrySubjectName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
