using Microsoft.EntityFrameworkCore;
using REPO_TUT.Data.Models;
using System;

namespace REPO_TUT.Data
{
    public class REPO_TUTDbContext : DbContext
    {
        public REPO_TUTDbContext(DbContextOptions<REPO_TUTDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Archivo> Archivos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alumno>()
         .HasMany(a => a.Materias)
         .WithMany(m => m.Alumnos)
         .UsingEntity<Dictionary<string, object>>(
             "AlumnoMateria",
             j => j.HasOne<Materia>()
                   .WithMany()
                   .HasForeignKey("MateriaId")
                   .HasConstraintName("FK_AlumnoMateria_MateriaId")
                   .OnDelete(DeleteBehavior.Cascade),
             j => j.HasOne<Alumno>()
                   .WithMany()
                   .HasForeignKey("AlumnoId")
                   .HasConstraintName("FK_AlumnoMateria_AlumnoId")
                   .OnDelete(DeleteBehavior.Cascade));
            // Relación muchos-a-muchos entre Materia y Archivo
            modelBuilder.Entity<Materia>()
                .HasMany(m => m.Archivos)
                .WithMany(a => a.Materias)
                .UsingEntity<Dictionary<string, object>>(
                    "MateriaArchivo",
                    j => j.HasOne<Archivo>()
                          .WithMany()
                          .HasForeignKey("ArchivoId")
                          .HasConstraintName("FK_MateriaArchivo_ArchivoId")
                          .OnDelete(DeleteBehavior.Cascade),
                    j => j.HasOne<Materia>()
                          .WithMany()
                          .HasForeignKey("MateriaId")
                          .HasConstraintName("FK_MateriaArchivo_MateriaId")
                          .OnDelete(DeleteBehavior.Cascade));




        }
    }
}
