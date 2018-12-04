namespace ExampleASP.NET.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=NewExamDbContext")
        {
        }

        public virtual DbSet<Exam> Exams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
