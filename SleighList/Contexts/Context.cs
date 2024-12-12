using SleighList.Models;
using Microsoft.EntityFrameworkCore;

namespace SleighList.Contexts{

    public class Context : DbContext{
        public Context(){

        }

        public Context(DbContextOptions<Context> options) : base(options) { 
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
                // colocar as informacoes do banco
                // As configuracoes existem?
                if(!optionsBuilder.IsConfigured){
                    
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-D69BRM9\\SQLEXPRESS02; Initial Catalog = SleighList; User Id=sa; Password=123; TrustServerCertificate = true");

                }
        }

        public DbSet<Usuario> Usuario {get; set;}

        public DbSet<Item> Item {get; set;}
    }
}