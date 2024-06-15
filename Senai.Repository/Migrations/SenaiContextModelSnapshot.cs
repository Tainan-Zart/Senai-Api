﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Senai.Repository.Context;

#nullable disable

namespace Senai.Repository.Migrations
{
    [DbContext(typeof(SenaiContext))]
    partial class SenaiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Senai.Domain.Entidades.Aluno", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ClasseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Classe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ClasseId")
                        .HasColumnType("bigint");

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProfessorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Serie")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId");

                    b.HasIndex("ProfessorId")
                        .IsUnique();

                    b.ToTable("Classe");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Escola", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.ToTable("Escola");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Nota", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AlunoId")
                        .HasColumnType("bigint");

                    b.Property<int>("Disciplina")
                        .HasColumnType("integer");

                    b.Property<decimal>("Notas")
                        .HasColumnType("numeric");

                    b.Property<int>("Semestre")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.ToTable("Nota");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Professor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("EscolaId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.HasKey("Id");

                    b.HasIndex("EscolaId");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Aluno", b =>
                {
                    b.HasOne("Senai.Domain.Entidades.Classe", "Classe")
                        .WithMany("Alunos")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Classe", b =>
                {
                    b.HasOne("Senai.Domain.Entidades.Escola", "Escola")
                        .WithMany("Classes")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Senai.Domain.Entidades.Professor", "Professor")
                        .WithOne("Classe")
                        .HasForeignKey("Senai.Domain.Entidades.Classe", "ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Endereco", b =>
                {
                    b.HasOne("Senai.Domain.Entidades.Escola", "Escola")
                        .WithOne("Endereco")
                        .HasForeignKey("Senai.Domain.Entidades.Endereco", "EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Nota", b =>
                {
                    b.HasOne("Senai.Domain.Entidades.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Professor", b =>
                {
                    b.HasOne("Senai.Domain.Entidades.Escola", "Escola")
                        .WithMany("Professores")
                        .HasForeignKey("EscolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escola");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Classe", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Escola", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Professores");
                });

            modelBuilder.Entity("Senai.Domain.Entidades.Professor", b =>
                {
                    b.Navigation("Classe")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
