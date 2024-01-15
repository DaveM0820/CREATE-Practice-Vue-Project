using Microsoft.EntityFrameworkCore;
using my_vue_backend;

public class PatientContext : DbContext
{
    public PatientContext(DbContextOptions<PatientContext> options)
        : base(options) {
    }

    public DbSet<Patient> Patients
    {
        get; set;
    }
}