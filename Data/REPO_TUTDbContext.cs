using Microsoft.EntityFrameworkCore;
using REPO_TUT.Data.Models;
using System;

namespace REPO_TUT.Data
{
    public class REPO_TUTDbContext : DbContext
    {
        // Definición de las tablas en la base de datos a través de DbSet.
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Archivo> Archivos { get; set; }

        // Constructor que recibe las opciones de configuración del contexto. Viene de DbContext. Vacío.
        public REPO_TUTDbContext(DbContextOptions<REPO_TUTDbContext> options) : base(options) { }

        // Método para configurar el modelo de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
