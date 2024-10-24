using Microsoft.EntityFrameworkCore;

namespace PrescriptionManagementSystem.Infrastructure;

public class PrescriptionManagementSystemDbContext : DbContext
{
    public PrescriptionManagementSystemDbContext(
        DbContextOptions<PrescriptionManagementSystemDbContext> options
    )
        : base(options) { }
}
