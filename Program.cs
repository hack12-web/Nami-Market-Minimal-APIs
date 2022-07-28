using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NamiMarket.Data;
using NamiMarket.Dtos;
using NamiMarket.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var sqlConBuilder = new SqlConnectionStringBuilder();

sqlConBuilder.ConnectionString = builder.Configuration.GetConnectionString("SQLDbConnection");
sqlConBuilder.UserID = builder.Configuration["UserID"];
sqlConBuilder.Password = builder.Configuration["Password"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(sqlConBuilder.ConnectionString));

builder.Services.AddScoped<IAdminRepo, AdminRepo>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IFinanceRepo, FinanceRepo>();
builder.Services.AddScoped<IPaymentRepo, PaymentRepo>();
builder.Services.AddScoped<IPayrollRepo, PayrollRepo>();
builder.Services.AddScoped<IReceptionistRepo, ReceptionistRepo>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//EndPoint Admi
app.MapGet("api/v1/admins", async (IAdminRepo repo, IMapper mapper) =>{
    var _getAdmin = await repo.GetAllAdmins();
    return Results.Ok(mapper.Map<IEnumerable<AdminReadDto>>(_getAdmin));
});
app.MapGet("api/v1/admins/{id}", async (IAdminRepo repo, IMapper mapper, int id) =>{
    var _getAdmin = await repo.GetAdminById(id);
    if(_getAdmin == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(mapper.Map<AdminReadDto>(_getAdmin));
});
app.MapPost("api/v1/admins", async (IAdminRepo repo, IMapper mapper, AdminCreateDto admCreateDto) =>{
    var _createAdmin = mapper.Map<AdminModel>(admCreateDto);
    await repo.CreateAdmin(_createAdmin);
    await repo.SaveChanges();
    var _readAdmin = mapper.Map<AdminReadDto>(_createAdmin);
    return Results.Created($"api/v1/admins/{_readAdmin.Id}", _readAdmin);
});
app.MapPut("api/v1/admins/{id}", async (IAdminRepo repo, IMapper mapper, int id, AdminUpdateDto admUpdateDto) =>{
    var _getAdminById = await repo.GetAdminById(id);
    if(_getAdminById == null)
    {
        return Results.NotFound();
    }
    mapper.Map(admUpdateDto, _getAdminById);
    await repo.SaveChanges();
    return Results.NoContent();
});
app.MapDelete("api/v1/admins/{id}", async (IAdminRepo repo, IMapper mapper, int id) =>{
    var _deleteAdmin = await repo.GetAdminById(id);
    if(_deleteAdmin == null)
    {
        return Results.NotFound();
    }
    repo.DeleteAdmin(_deleteAdmin);
    await repo.SaveChanges();
    return Results.NoContent();
});
//EndPoint Admin Done
// EndPoint Customers
app.MapGet("api/v1/customers", async (ICustomerRepo repo, IMapper mapper) =>{
    var _getCustomers = await repo.GetAllCustomers();
    return Results.Ok(mapper.Map<IEnumerable<CustomerReadDto>>(_getCustomers));
});
app.MapGet("api/v1/customers/{id}", async (ICustomerRepo repo, IMapper mapper, int id) =>{
    var _getCustomerById = await repo.GetCustomerById(id);
    if(_getCustomerById == null)
    {
        return Results.NotFound();    
    }
    return Results.Ok(mapper.Map<CustomerReadDto>(_getCustomerById));  
});
app.MapPost("api/v1/customers", async (ICustomerRepo repo, IMapper mapper, CustomerCreateDto customerCreateDto) =>{
    var _createCustomer = mapper.Map<CustomerModel>(customerCreateDto);
    await repo.CreateCustomer(_createCustomer);
    await repo.SaveChanges();
    var _readCustomer = mapper.Map<CustomerReadDto>(_createCustomer);
    return Results.Created($"api/v1/customers/{_readCustomer.Id}", _readCustomer);
});
app.MapPut("api/v1/customers/{id}", async (ICustomerRepo repo, IMapper mapper, CustomerUpdateDto customerUpdateDto, int id) =>{
    var _getCustomersById = await repo.GetCustomerById(id);
    if(_getCustomersById == null){
        return Results.NotFound();
    }
    mapper.Map(customerUpdateDto, _getCustomersById);
    await repo.SaveChanges();
    return Results.NoContent();
});
app.MapDelete("api/v1/customers/{id}", async (ICustomerRepo repo, IMapper mapper, int id) =>{
    var _deleteCustomer = await repo.GetCustomerById(id);
    if(_deleteCustomer == null)
    {
        return Results.NotFound();
    }
    repo.DeleteCustomer(_deleteCustomer);
    await repo.SaveChanges();
    return Results.NoContent();
});
//EndPoint Customers Done
//EndPoint Customers Start
app.MapGet("api/v1/finances", async (IFinanceRepo repo, IMapper mapper) =>{
    var _getFinances = await repo.GetAllFinances();
    return Results.Ok(mapper.Map<IEnumerable<FinanceReadDto>>(_getFinances));
});
app.MapGet("api/v1/finances/{id}", async (IFinanceRepo repo, IMapper mapper, int id) =>{
    var _getFinanceById = await repo.GetFinanceById(id);
    if(_getFinanceById == null)
    {
        return Results.NotFound();    
    }
    return Results.Ok(mapper.Map<FinanceReadDto>(_getFinanceById));  
});
app.MapPost("api/v1/finances", async (IFinanceRepo repo, IMapper mapper, FinanceCreateDto financeCreateDto) =>{
    var _createFinance = mapper.Map<FinanceModel>(financeCreateDto);
    await repo.CreateFinance(_createFinance);
    await repo.SaveChanges();
    var _readFinance = mapper.Map<FinanceReadDto>(_createFinance);
    return Results.Created($"api/v1/finances/{_readFinance.Id}", _readFinance);
});
app.MapPut("api/v1/finances/{id}", async (IFinanceRepo repo, IMapper mapper, FinanceUpdateDto financeUpdateDto, int id) =>{
    var _getFinanceById = await repo.GetFinanceById(id);
    if(_getFinanceById == null){
        return Results.NotFound();
    }
    mapper.Map(financeUpdateDto, _getFinanceById);
    await repo.SaveChanges();
    return Results.NoContent();
});
app.MapDelete("api/v1/finances/{id}", async (IFinanceRepo repo, IMapper mapper, int id) =>{
    var _deleteFinance = await repo.GetFinanceById(id);
    if(_deleteFinance == null)
    {
        return Results.NotFound();
    }
    repo.DeleteFinance(_deleteFinance);
    await repo.SaveChanges();
    return Results.NoContent();
});
//EndPoint Finance Done
//EndPoint Payments
app.MapGet("api/v1/payments", async (IPaymentRepo repo, IMapper mapper) =>{
    var _getPayments = await repo.GetAllPayments();
    return Results.Ok(mapper.Map<IEnumerable<PaymentReadDto>>(_getPayments));
});
app.MapGet("api/v1/payments/{id}", async (IPaymentRepo repo, IMapper mapper, int id) =>{
    var _getPaymentById = await repo.GetPaymentById(id);
    if(_getPaymentById == null)
    {
        return Results.NotFound();    
    }
    return Results.Ok(mapper.Map<PaymentReadDto>(_getPaymentById));  
});
app.MapPost("api/v1/payments", async (IPaymentRepo repo, IMapper mapper, PaymentCreateDto paymentCreateDto) =>{
    var _createPayment = mapper.Map<PaymentModel>(paymentCreateDto);
    await repo.CreatePayment(_createPayment);
    await repo.SaveChanges();
    var _readPayment = mapper.Map<PaymentReadDto>(_createPayment);
    return Results.Created($"api/v1/payments/{_readPayment.Id}", _readPayment);
});
app.MapPut("api/v1/payments/{id}", async (IPaymentRepo repo, IMapper mapper, PaymentUpdateDto paymentUpdateDto, int id) =>{
    var _getPaymentById = await repo.GetPaymentById(id);
    if(_getPaymentById == null){
        return Results.NotFound();
    }
    mapper.Map(paymentUpdateDto, _getPaymentById);
    await repo.SaveChanges();
    return Results.NoContent();
});
app.MapDelete("api/v1/payments/{id}", async (IPaymentRepo repo, IMapper mapper, int id) =>{
    var _deletePayment = await repo.GetPaymentById(id);
    if(_deletePayment == null)
    {
        return Results.NotFound();
    }
    repo.DeletePayment(_deletePayment);
    await repo.SaveChanges();
    return Results.NoContent();
});
//EndPoint Fininsh Payment
//EndPoint Payroll Start
app.MapGet("api/v1/payrolls", async (IPayrollRepo repo, IMapper mapper) =>{
    var _getPayrolls = await repo.GetAllPayrolls();
    return Results.Ok(mapper.Map<IEnumerable<PayrollReadDto>>(_getPayrolls));
});
app.MapGet("api/v1/payrolls/{id}", async (IPayrollRepo repo, IMapper mapper, int id) =>{
    var _getPayrollById = await repo.GetPayrollById(id);
    if(_getPayrollById == null)
    {
        return Results.NotFound();    
    }
    return Results.Ok(mapper.Map<PayrollReadDto>(_getPayrollById));  
});
app.MapPost("api/v1/payrolls", async (IPayrollRepo repo, IMapper mapper, PayrollCreateDto payrollCreateDto) =>{
    var _createPayroll = mapper.Map<PayrollModel>(payrollCreateDto);
    await repo.CreatePayroll(_createPayroll);
    await repo.SaveChanges();
    var _readPayroll = mapper.Map<PayrollReadDto>(_createPayroll);
    return Results.Created($"api/v1/payrolls/{_readPayroll.Id}", _readPayroll);
});
app.MapPut("api/v1/payrolls/{id}", async (IPayrollRepo repo, IMapper mapper, PayrollUpdateDto payrollUpdateDto, int id) =>{
    var _getPayrollById = await repo.GetPayrollById(id);
    if(_getPayrollById == null){
        return Results.NotFound();
    }
    mapper.Map(payrollUpdateDto, _getPayrollById);
    await repo.SaveChanges();
    return Results.NoContent();
});
app.MapDelete("api/v1/payrolls/{id}", async (IPayrollRepo repo, IMapper mapper, int id) =>{
    var _deletePayroll = await repo.GetPayrollById(id);
    if(_deletePayroll == null)
    {
        return Results.NotFound();
    }
    repo.DeletePayroll(_deletePayroll);
    await repo.SaveChanges();
    return Results.NoContent();
});
//EndPoint Fininsh Payrolls
//EndPoint Receptionist Start
app.MapGet("api/v1/receptionists", async (IReceptionistRepo repo, IMapper mapper) =>{
    var _getReceptionists = await repo.GetAllReceptionists();
    return Results.Ok(mapper.Map<IEnumerable<ReceptionistReadDto>>(_getReceptionists));
});
app.MapGet("api/v1/receptionists/{id}", async (IReceptionistRepo repo, IMapper mapper, int id) =>{
    var _getReceptionistById = await repo.GetReceptionistById(id);
    if(_getReceptionistById == null)
    {
        return Results.NotFound();    
    }
    return Results.Ok(mapper.Map<ReceptionistReadDto>(_getReceptionistById));  
});
app.MapPost("api/v1/receptionists", async (IReceptionistRepo repo, IMapper mapper, ReceptionistCreateDto receptionistCreateDto) =>{
    var _createReceptionist = mapper.Map<ReceptionistModel>(receptionistCreateDto);
    await repo.CreateReceptionist(_createReceptionist);
    await repo.SaveChanges();
    var _readReceptionist = mapper.Map<ReceptionistReadDto>(_createReceptionist);
    return Results.Created($"api/v1/receptionists/{_readReceptionist.Id}", _readReceptionist);
});
app.MapPut("api/v1/receptionists/{id}", async (IReceptionistRepo repo, IMapper mapper, ReceptionistUpdateDto receptionistUpdateDto, int id) =>{
    var _getReceptionistById = await repo.GetReceptionistById(id);
    if(_getReceptionistById == null){
        return Results.NotFound();
    }
    mapper.Map(receptionistUpdateDto, _getReceptionistById);
    await repo.SaveChanges();
    return Results.NoContent();
});
app.MapDelete("api/v1/receptionists/{id}", async (IReceptionistRepo repo, IMapper mapper, int id) =>{
    var _deleteReceptionist = await repo.GetReceptionistById(id);
    if(_deleteReceptionist == null)
    {
        return Results.NotFound();
    }
    repo.DeleteReceptionist(_deleteReceptionist);
    await repo.SaveChanges();
    return Results.NoContent();
});
//EndPoint Finish Receptionist
app.Run();

