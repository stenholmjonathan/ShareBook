﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShareBookApi.Context;

#nullable disable

namespace ShareBook.Migrations
{
    [DbContext(typeof(ShareBookContext))]
    [Migration("20240214093452_mig")]
    partial class mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShareBookApi.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                            ProfileId = 1,
                            Subject = "The standard Lorem Ipsum passage, used since the 1500s"
                        },
                        new
                        {
                            Id = 2,
                            Message = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.",
                            ProfileId = 1,
                            Subject = "Section 1.10.32 of \"de Finibus Bonorum et Malorum\""
                        },
                        new
                        {
                            Id = 3,
                            Message = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet.",
                            ProfileId = 1,
                            Subject = "1914 translation by H. Rackham"
                        },
                        new
                        {
                            Id = 4,
                            Message = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form,",
                            ProfileId = 1,
                            Subject = "Section 1.10.33 of \"de Finibus Bonorum et Malorum\""
                        },
                        new
                        {
                            Id = 5,
                            Message = "There are many variations of passages of Lorem Ipsum available.",
                            ProfileId = 1,
                            Subject = "1914 translation by H. Rackham"
                        },
                        new
                        {
                            Id = 6,
                            Message = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                            ProfileId = 1,
                            Subject = "Donate"
                        },
                        new
                        {
                            Id = 7,
                            Message = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary,",
                            ProfileId = 1,
                            Subject = "1500s"
                        },
                        new
                        {
                            Id = 8,
                            Message = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                            ProfileId = 1,
                            Subject = "Written by Cicero in 45 BC"
                        },
                        new
                        {
                            Id = 9,
                            Message = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself.",
                            ProfileId = 1,
                            Subject = "There is a set of mock banners available"
                        },
                        new
                        {
                            Id = 10,
                            Message = "hej hej",
                            ProfileId = 2,
                            Subject = "min allra första post"
                        },
                        new
                        {
                            Id = 11,
                            Message = "hej svej",
                            ProfileId = 2,
                            Subject = "min trökiga andra post"
                        });
                });

            modelBuilder.Entity("ShareBookApi.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Mitt namn är Jonathan",
                            Name = "Jonathan"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Mitt namn är Johan",
                            Name = "Johan"
                        });
                });

            modelBuilder.Entity("ShareBookApi.Models.BlogPost", b =>
                {
                    b.HasOne("ShareBookApi.Models.Profile", null)
                        .WithMany("Posts")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShareBookApi.Models.Profile", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
