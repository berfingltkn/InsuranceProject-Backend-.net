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
    public class CoverageManager : ICoverageService
    {
        ICoverageDal _coverageDal;

        public CoverageManager(ICoverageDal coverageDal)
        {
            _coverageDal = coverageDal;
        }
        public IResult Add(Coverage coverage)
        {
            _coverageDal.Add(coverage);
            return new SuccessResult("coverage added");
        }

        public IResult Delete(Coverage coverage)
        {
            var deletedCoverage = _coverageDal.Get(c => c.offerNo == coverage.offerNo);
            _coverageDal.Delete(deletedCoverage);
            return new SuccessResult("coverage deleted");
        }

        public IDataResult<List<Coverage>> GetAll()
        {
            return new SuccessDataResult<List<Coverage>>(_coverageDal.GetAll(), "coverages listed");

        }

        public IResult Update(Coverage coverage)
        {
            _coverageDal.Update(coverage);
            return new SuccessResult("coverage updated");
        }
    }
}
