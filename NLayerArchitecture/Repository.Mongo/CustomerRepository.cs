using Core;
using System;

namespace Repository.Mongo
{
    public class CustomerRepository : ICustomerRepository
    {
        public int GetCustomerCount()
        {
            return 1;
        }
    }
}
