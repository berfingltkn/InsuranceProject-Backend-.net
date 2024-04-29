using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IPolicyCoverageService
    {
        IDataResult<List<PolicyCoverage>> GetAll();
        IResult Add(PolicyCoverage policyCoverage);
        IResult Update(PolicyCoverage policyCoverage);
        IResult Delete(PolicyCoverage policyCoverage);
    }
}
