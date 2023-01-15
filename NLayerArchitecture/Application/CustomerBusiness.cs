using Core;

namespace Application
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerBusiness(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public int GetCustomerCount()
        {
            return this.customerRepository.GetCustomerCount();
        }
    }
}
