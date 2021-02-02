namespace Prescriptions.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PrescriptionCotext : DbContext
    {
        // Your context has been configured to use a 'PrescriptionCotext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Prescriptions.Models.PrescriptionCotext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PrescriptionCotext' 
        // connection string in the application configuration file.
        public PrescriptionCotext()
            : base("name=PrescriptionCotext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Clinic> Clinics{ get; set; }
        public virtual DbSet<Doctor> Doctors{ get; set; }
        public virtual DbSet<Pation> Pations{ get; set; }
        public virtual DbSet<RX> Rxs{ get; set; }
        public virtual DbSet<RxDetail> RxDetails{ get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}