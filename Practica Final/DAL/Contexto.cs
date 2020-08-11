using Microsoft.EntityFrameworkCore;
using Practica_Final.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Final.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Amigos> Amigos { get; set; }
        public DbSet<Juegos> Juegos { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\PrestamosDeJuegos.db");
        }
    }
}