using Businnes.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class PolicyManager : IPolicyService
    {
        IPolicyDal _policyDal;

        public PolicyManager(IPolicyDal policyDal)
        {
            _policyDal = policyDal;
        }
        public IResult Add(Policy policy)
        {
            _policyDal.Add(policy);
            return new SuccessResult("policy added");
        }

        public IResult Delete(Policy policy)
        {
            var deletedPolicy = _policyDal.Get(p => p.policyId == policy.policyId);
            _policyDal.Delete(deletedPolicy);
            return new SuccessResult("policy deleted");
        }

        public IDataResult<Policy> GePolicyIdByTcno(string customerIdNumber)
        {
            return new SuccessDataResult<Policy>(_policyDal.Get(p=>p.customerIdNumber== customerIdNumber), "policy listed with tcno");
        }

        public IDataResult<List<Policy>> GetAll()
        {
            return new SuccessDataResult<List<Policy>>(_policyDal.GetAll(), "policies listed");

        }

        public IResult Update(Policy policy)
        {
            _policyDal.Update(policy);
            return new SuccessResult("policy updated");
        }
    }
}
