using Microsoft.EntityFrameworkCore;
using REPO_TUT.Data.Models;
using System;

namespace REPO_TUT.Data
{
    public class REPOTUTDbContext : DbContext
    {
        public REPOTUTDbContext(DbContextOptions<REPOTUTDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}
