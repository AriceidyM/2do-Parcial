using Microsoft.EntityFrameworkCore;
using RegistroLLamada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroLLamada.Data
{
    public class Contexto :DbContext
    {
        public DbSet<Llamadas> Llamadas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/LLamadaDb.db");
        }
    }
}
