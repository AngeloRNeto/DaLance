using DaLance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DaLance.Entity
{
    public class DaLanceContext : DbContext
    {
        public DaLanceContext(DbContextOptions<DaLanceContext> options) : base(options)
        {
        }

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Produto> produtos { get; set; }
        public DbSet<Lance> lances { get; set; }
    }
}
