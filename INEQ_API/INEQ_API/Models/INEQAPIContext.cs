using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace INEQ_API.Models
{
    public class INEQAPIContext : DbContext
    {
        public INEQAPIContext() : base("INEQAPIContext")
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Component> Components { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}