using System.Collections.Generic;
using Data.Configuration;
using Data.Models;

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreEntities : DbContext
    {
        public StoreEntities() : base("StoreEntities")
        { 
        }

        public DbSet<Gadget> Gadgets { get; set; }
        public DbSet<Category> Categories { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GadgetConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }

    }

}