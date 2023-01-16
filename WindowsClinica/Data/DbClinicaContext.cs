using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsClinica.Models;

namespace WindowsClinica.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbClinicaContext() : base("dbKey") { }

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
