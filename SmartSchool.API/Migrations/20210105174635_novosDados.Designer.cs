﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210105174635_novosDados")]
    partial class novosDados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Fatima",
                            Sobrenome = "Pineda",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Isabella",
                            Sobrenome = "Martins",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Pietro",
                            Sobrenome = "Pineda",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Roberta",
                            Sobrenome = "Pineda",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Guilherme"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Giulia"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Cristiane"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Renato"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
