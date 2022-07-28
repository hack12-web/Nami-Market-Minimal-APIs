using Microsoft.EntityFrameworkCore;
using NamiMarket.Models;

namespace NamiMarket.Data
{
    public class AdminRepo : IAdminRepo
    {
        public readonly AppDbContext _context;
        public AdminRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAdmin(AdminModel admin)
        {
            if(admin == null)
            {
                throw new ArgumentNullException(nameof(admin));
            }
            await _context.AddAsync(admin);
        }
        public void DeleteAdmin(AdminModel admin)
        {
            if(admin == null)
            {
                throw new ArgumentNullException(nameof(admin));
            }
            _context.admins.Remove(admin);
        }
        public async Task<AdminModel> GetAdminById(int id)
        {
            return await _context.admins.FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<IEnumerable<AdminModel>> GetAllAdmins()
        {
            return await _context.admins.ToListAsync();
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;
        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateCustomer(CustomerModel customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            await _context.customers.AddAsync(customer);
        }
        public void DeleteCustomer(CustomerModel customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _context.customers.Remove(customer);
        }
        public async Task<IEnumerable<CustomerModel>> GetAllCustomers()
        {
            return await _context.customers.ToListAsync();
        }
        public async Task<CustomerModel> GetCustomerById(int id)
        {
            return await _context.customers.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
    public class FinanceRepo : IFinanceRepo
    {
        private readonly AppDbContext _context;
        public FinanceRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateFinance(FinanceModel finance)
        {
            if(finance == null)
            {
                throw new ArgumentNullException(nameof(finance));
            }
            await _context.finances.AddAsync(finance);
        }
        public void DeleteFinance(FinanceModel finance)
        {
            if(finance == null)
            {
                throw new ArgumentNullException(nameof(finance));
            }
            _context.finances.Remove(finance);
        }
        public async Task<IEnumerable<FinanceModel>> GetAllFinances()
        {
            return await _context.finances.ToListAsync();
        }
        public async Task<FinanceModel> GetFinanceById(int id)
        {
            return await _context.finances.FirstOrDefaultAsync(f => f.Id == id);
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
    public class PaymentRepo : IPaymentRepo
    {
        private readonly AppDbContext _context;
        public PaymentRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreatePayment(PaymentModel payment)
        {
            if(payment == null)
            {
                throw new ArgumentNullException(nameof(payment));
            }
            await _context.payments.AddAsync(payment);
        }
        public void DeletePayment(PaymentModel payment)
        {
            if(payment == null)
            {
                throw new ArgumentNullException(nameof(payment));
            }
            _context.payments.Remove(payment);
        }
        public async Task<IEnumerable<PaymentModel>> GetAllPayments()
        {
            return await _context.payments.ToListAsync();
        }
        public async Task<PaymentModel> GetPaymentById(int id)
        {
            return await _context.payments.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
    public class PayrollRepo : IPayrollRepo
    {
        private readonly AppDbContext _context;
        public PayrollRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreatePayroll(PayrollModel payroll)
        {
            if(payroll == null)
            {
                throw new ArgumentNullException(nameof(payroll));
            }
            await _context.payrolls.AddAsync(payroll);
        }
        public void DeletePayroll(PayrollModel payroll)
        {
            if(payroll == null)
            {
                throw new ArgumentNullException(nameof(payroll));
            }
            _context.payrolls.Remove(payroll);
        }
        public async Task<IEnumerable<PayrollModel>> GetAllPayrolls()
        {
            return await _context.payrolls.ToListAsync();
        }
        public async Task<PayrollModel> GetPayrollById(int id)
        {
            return await _context.payrolls.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
    public class ReceptionistRepo : IReceptionistRepo
    {
        private readonly AppDbContext _context;
        public ReceptionistRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateReceptionist(ReceptionistModel receptionist)
        {
            if(receptionist == null)
            {
                throw new ArgumentNullException(nameof(receptionist));
            }
            await _context.receptionists.AddAsync(receptionist);
        }
        public void DeleteReceptionist(ReceptionistModel receptionist)
        {
            if(receptionist == null)
            {
                throw new ArgumentNullException(nameof(receptionist));
            }
            _context.receptionists.Remove(receptionist);
        }
        public async Task<IEnumerable<ReceptionistModel>> GetAllReceptionists()
        {
            return await _context.receptionists.ToListAsync();
        }

        public async Task<ReceptionistModel> GetReceptionistById(int id)
        {
            return await _context.receptionists.FirstOrDefaultAsync(r => r.Id == id);
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}