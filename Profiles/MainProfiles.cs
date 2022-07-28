using AutoMapper;
using NamiMarket.Dtos;
using NamiMarket.Models;

namespace NamiMarket.Profiles
{
    public class AdminProfile : Profile
    {
        public AdminProfile()
        {
            CreateMap<AdminModel, AdminReadDto>();
            CreateMap<AdminCreateDto, AdminModel>();
            CreateMap<AdminUpdateDto, AdminModel>();
        }
    }
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, CustomerReadDto>();
            CreateMap<CustomerCreateDto, CustomerModel>();
            CreateMap<CustomerUpdateDto, CustomerModel>();
        }
    }
    public class FinanceProfile : Profile
    {
        public FinanceProfile()
        {
            CreateMap<FinanceModel, FinanceReadDto>();
            CreateMap<FinanceCreateDto, FinanceModel>();
            CreateMap<FinanceUpdateDto, FinanceModel>();
        }
    }
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentModel, PaymentReadDto>();
            CreateMap<PaymentCreateDto, PaymentModel>();
            CreateMap<PaymentUpdateDto, PaymentModel>();
        }
    }
    public class PayrollProfile : Profile
    {
        public PayrollProfile()
        {
            CreateMap<PayrollModel, PayrollReadDto>();
            CreateMap<PayrollCreateDto, PayrollModel>();
            CreateMap<PayrollUpdateDto, PayrollModel>();
        }
    }
    public class ReceptionistProfile : Profile
    {
        public ReceptionistProfile()
        {
            CreateMap<ReceptionistModel, ReceptionistReadDto>();
            CreateMap<ReceptionistCreateDto, ReceptionistModel>();
            CreateMap<ReceptionistUpdateDto, ReceptionistModel>();
        }
    }
}