﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TaskManager.Api.Context;

#nullable disable

namespace TaskManager.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240520204423_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TaskManager.Common.Models.Attachment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Observer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskId");

                    b.ToTable("Observers");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CreatorEmployeeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeOnly>("FinishScheduledTime")
                        .HasColumnType("time without time zone");

                    b.Property<string>("FullTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ResponsibleEmployeeId")
                        .HasColumnType("uuid");

                    b.Property<string>("ShortTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeOnly>("StartScheduledTime")
                        .HasColumnType("time without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatorEmployeeId");

                    b.HasIndex("ResponsibleEmployeeId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uuid");

                    b.Property<TimeOnly>("FinishTime")
                        .HasColumnType("time without time zone");

                    b.Property<string>("FullTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PreviousId")
                        .HasColumnType("uuid");

                    b.Property<string>("ShortTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time without time zone");

                    b.Property<int>("TaskStatusId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ExecutorId");

                    b.HasIndex("PreviousId");

                    b.HasIndex("TaskStatusId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TaskManager.Common.Models.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Attachment", b =>
                {
                    b.HasOne("TaskManager.Common.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Comment", b =>
                {
                    b.HasOne("TaskManager.Common.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Common.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Observer", b =>
                {
                    b.HasOne("TaskManager.Common.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Common.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Project", b =>
                {
                    b.HasOne("TaskManager.Common.Models.Employee", "CreatorEmployee")
                        .WithMany()
                        .HasForeignKey("CreatorEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Common.Models.Employee", "ResponsibleEmployee")
                        .WithMany()
                        .HasForeignKey("ResponsibleEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatorEmployee");

                    b.Navigation("ResponsibleEmployee");
                });

            modelBuilder.Entity("TaskManager.Common.Models.Task", b =>
                {
                    b.HasOne("TaskManager.Common.Models.Employee", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Common.Models.Employee", "Executor")
                        .WithMany()
                        .HasForeignKey("ExecutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Common.Models.Task", "Previous")
                        .WithMany()
                        .HasForeignKey("PreviousId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Common.Models.TaskStatus", "TaskStatus")
                        .WithMany()
                        .HasForeignKey("TaskStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Executor");

                    b.Navigation("Previous");

                    b.Navigation("TaskStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
