using Fiap06.WEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap06.WEB.MVC.Persistencia
{
    public class EstadoContext : DbContext
    {

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

    }
}