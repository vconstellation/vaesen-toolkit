using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaesenToolkit.Models;

namespace VaesenToolkit.Services
{
    internal class DatabaseContext: DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public string DbPath { get; }

        public DatabaseContext()
        {

            var path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "vaesen_temp.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
