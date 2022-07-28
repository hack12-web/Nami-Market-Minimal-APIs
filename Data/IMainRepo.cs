using NamiMarket.Models;

namespace NamiMarket.Data
{
    public interface IAdminRepo
    {
        Task SaveChanges();
        Task<AdminModel>GetAdminById(int id);
        Task<IEnumerable<AdminModel>> GetAllAdmins();
        Task CreateAdmin(AdminModel admin);
        void DeleteAdmin(AdminModel admin);
    }
    public interface ICustomerRepo
    {
        Task SaveChanges();
        Task<CustomerModel>GetCustomerById(int id);
        Task<IEnumerable<CustomerModel>> GetAllCustomers();
        Task CreateCustomer(CustomerModel customer);
        void DeleteCustomer(CustomerModel customer);
    }
    public interface IFinanceRepo
    {
        Task SaveChanges();
        Task<FinanceModel>GetFinanceById(int id);
        Task<IEnumerable<FinanceModel>> GetAllFinances();
        Task CreateFinance(FinanceModel finance);
        void DeleteFinance(FinanceModel finance);
    }
    public interface IPaymentRepo
    {
        Task SaveChanges();
        Task<PaymentModel>GetPaymentById(int id);
        Task<IEnumerable<PaymentModel>>GetAllPayments();
        Task CreatePayment(PaymentModel payment);
        void DeletePayment(PaymentModel payment);
    }
    public interface IPayrollRepo
    {
        Task SaveChanges();
        Task<PayrollModel>GetPayrollById(int id);
        Task<IEnumerable<PayrollModel>>GetAllPayrolls();
        Task CreatePayroll(PayrollModel payroll);
        void DeletePayroll(PayrollModel payroll);
    }
    public interface IReceptionistRepo
    {
        Task SaveChanges();
        Task<ReceptionistModel>GetReceptionistById(int id);
        Task<IEnumerable<ReceptionistModel>>GetAllReceptionists();
        Task CreateReceptionist(ReceptionistModel receptionist);
        void DeleteReceptionist(ReceptionistModel receptionistModel);
    }
}