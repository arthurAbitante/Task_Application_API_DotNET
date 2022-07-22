using DielWepApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DielAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
            
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarefa>().HasKey(t => t.id);
            modelBuilder.Entity<Tarefa>().Property(t => t.titulo).HasMaxLength(255);
            modelBuilder.Entity<Tarefa>().Property(t => t.descricao).HasMaxLength(255);
            modelBuilder.Entity<Tarefa>().Property(t => t.data);
            modelBuilder.Entity<Tarefa>().Property(t => t.tempoDuracao);
            modelBuilder.Entity<Tarefa>().Property(t => t.tipo).HasMaxLength(8);


        }

    }
}
