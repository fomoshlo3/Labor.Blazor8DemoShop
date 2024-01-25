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
            _context.Customers.Add(new Customer
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.CustomerName.Split(" ")[0],
                LastName = customer.CustomerName.Split(" ")[1],
                Birthday = customer.Birthday,
                GenderID = customer.GenderId,
            });
        }

        public void DeleteCustomer(int id)
        {
            var toDelete = _context.Customers.Find(id);
            if (toDelete != null)

            _context.Customers.Remove(toDelete);
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
