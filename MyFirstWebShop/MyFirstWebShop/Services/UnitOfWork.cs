using MyFirstWebShop.Data;

namespace MyFirstWebShop.Services
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private GenderService? _genderService = null;
        private CustomerService? _customerService = null;

        public GenderService GenderService => _genderService ??= new GenderService(_context);
        public CustomerService CustomerService => _customerService ??= new CustomerService(_context);

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<int> Commit()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
