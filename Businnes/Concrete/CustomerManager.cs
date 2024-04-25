using Businnes.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            
            _customerDal.Add(customer);
            return new SuccessResult("customer added");
        }

        public IResult Delete(Customer customer)
        {
            var deletedCustomer=_customerDal.Get(c=>c.user_id == customer.user_id);
            _customerDal.Delete(deletedCustomer);
            return new SuccessResult("customer deleted");
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), "customers listed");
        }

        public IDataResult<Customer> GetCustomerByTcno(int tcno)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(t=>t.tc_no==tcno),"customer listed with tcno");
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult("customer updated");
        }
    }
}
