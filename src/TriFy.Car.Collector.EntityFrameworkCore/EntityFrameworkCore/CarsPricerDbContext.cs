﻿using Microsoft.EntityFrameworkCore;
using TriFy.Car.Collector.Products;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;


namespace TriFy.Car.Collector.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See CarCollectorMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public partial class CarsPricerDbContext : AbpDbContext<CarsPricerDbContext>
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside CarCollectorDbContextModelCreatingExtensions.ConfigureCarCollector
         */

        public CarsPricerDbContext(DbContextOptions<CarsPricerDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure your own tables/entities inside the ConfigureCarCollector method */

            builder.ConfigureCarCollector();
        }
    }
}
