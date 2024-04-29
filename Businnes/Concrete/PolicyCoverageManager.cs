using Businnes.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Concrete
{
    public class PolicyCoverageManager : IPolicyCoverageService
    {
        IPolicyCoverageDal _policyCoverageDal;
        

        public PolicyCoverageManager(IPolicyCoverageDal policyCoverageDal)
        {
            _policyCoverageDal = policyCoverageDal;
        }

        public IResult Add(PolicyCoverage policyCoverage)
        {
            _policyCoverageDal.Add(policyCoverage);
            return new SuccessResult(" added");
        }

        public IResult Delete(PolicyCoverage policyCoverage)
        {
            var deleted = _policyCoverageDal.Get(p => p.policyID== policyCoverage.policyID);
            _policyCoverageDal.Delete(deleted);
            return new SuccessResult(" deleted");
        }

        public IDataResult<List<PolicyCoverage>> GetAll()
        {
            return new SuccessDataResult<List<PolicyCoverage>>(_policyCoverageDal.GetAll(), " listed");

        }

        public IResult Update(PolicyCoverage policyCoverage)
        {
            _policyCoverageDal.Update(policyCoverage);
            return new SuccessResult(" updated");
        }
    }
}
