namespace DavidCore.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DavidCloud : DbContext
    {
        // Your context has been configured to use a 'DavidCloud' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DavidPortal.Unity.DavidCloud' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DavidCloud' 
        // connection string in the application configuration file.
        public DavidCloud() : base("name=DavidCloud")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<DavidConsole> DavidConsoles { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var hospitalTable = modelBuilder.Entity<Hospital>().ToTable("Hospitals");
            hospitalTable.MapToStoredProcedures();

            var DavidConsoleTable = modelBuilder.Entity<DavidConsole>().ToTable("DavidConsoles");
            DavidConsoleTable.MapToStoredProcedures();

            base.OnModelCreating(modelBuilder);
        }
    }
}