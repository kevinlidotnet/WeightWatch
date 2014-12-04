using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplicationSnow.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcApplicationSnow.DAL
{
    public class SnowContext : DbContext
    {

        public SnowContext(): base("SnowContext")
        {
        }

        public DbSet<Weight> Weights { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Weight>().HasKey(x => x.WeightID);
            base.OnModelCreating(modelBuilder);
        }  
    }
}