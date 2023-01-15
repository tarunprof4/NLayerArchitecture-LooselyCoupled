using Core;

namespace Repository.Mssql
{
    public class CustomerRepository : ICustomerRepository
    {
        public int GetCustomerCount()
        {
            return 1;
        }
    }
}
