using Microsoft.EntityFrameworkCore;
using NamiMarket.Models;

namespace NamiMarket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<AdminModel> admins => Set<AdminModel>();
        public DbSet<CustomerModel> customers => Set<CustomerModel>();
        public DbSet<FinanceModel> finances => Set<FinanceModel>();
        public DbSet<PaymentModel> payments => Set<PaymentModel>();
        public DbSet<PayrollModel> payrolls => Set<PayrollModel>();
        public DbSet<ReceptionistModel> receptionists => Set<ReceptionistModel>();
    }
}