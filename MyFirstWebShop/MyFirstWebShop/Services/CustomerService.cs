using MyFirstWebShop.Data;
using MyFirstWebShop.Data.DTOs;
using MyFirstWebShop.Data.Entity;

namespace MyFirstWebShop.Services
{
    public class CustomerService : ICustomerService
    {
        ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(CustomerDetailDTO customer)
        {
            try
            {
                using (_context)
                {
                    new Customer
                    {
                        CustomerId = customer.CustomerId,
                        Birthday = customer.Birthday,
                        
                    };
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CustomerDetailDTO>> GetAllCustomerDetailDTOsAsync()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDetailDTO> GetCustomerDetailDTOAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(CustomerDetailDTO customer)
        {
            throw new NotImplementedException();
        }
    }
}
