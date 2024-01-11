using MyFirstWebShop.Data.DTOs;
using MyFirstWebShop.Data.Entity;

namespace MyFirstWebShop.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerDetailDTO>> GetAllCustomerDetailDTOsAsync();

        Task<CustomerDetailDTO> GetCustomerDetailDTOAsync(int id);

        void AddCustomer(CustomerDetailDTO customer);

        void DeleteCustomer(int id);

        void UpdateCustomer(CustomerDetailDTO customer);

        Customer GetCustomer(int id);
    }
}
