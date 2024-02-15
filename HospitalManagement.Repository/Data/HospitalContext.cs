using Hospital.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositories.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
        {
            
        }

        public DbSet<Doctor> Doctors { set; get; }

        public DbSet<Patient> Patients { set; get; }

        public DbSet<Medicine> Medicines { set; get; }
    }
}
