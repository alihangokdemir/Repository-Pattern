﻿using System.Data.Entity.ModelConfiguration;
using Data.Models;

namespace Data.Configuration
{
    public class GadgetConfiguration : EntityTypeConfiguration<Gadget>
    {
        public GadgetConfiguration()
        {
            ToTable("Gadgets");
            Property(g => g.Name).IsRequired().HasMaxLength(50);
            Property(g => g.Price).IsRequired().HasPrecision(8, 2);
            Property(g => g.CategoryID).IsRequired();
        }
    }
}