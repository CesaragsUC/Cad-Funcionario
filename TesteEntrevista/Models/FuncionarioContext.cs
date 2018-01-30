using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CadFuncionario.Models
{
    public class FuncionarioContext : DbContext
    {
        public  FuncionarioContext() : base("DefaultConnection")
        {

        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder) // metodo que retira tipo plural  no nomes das tabelas
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder); 
        }


       public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}