﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenThiKham330.Migrations
{
    [DbContext(typeof(LTQLDb))]
    partial class LTQLDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("NguyenThiKham330.Model.UniversityNTK330", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("UniversityName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UniversityId");

                    b.ToTable("UniversityNTK330");
                });
#pragma warning restore 612, 618
        }
    }
}
