using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface IPolicyService
    {
        IDataResult<Policy> GePolicyIdByTcno(int customerIdNumber);
        IDataResult<List<Policy>> GetAll();
        IResult Add(Policy policy);
        IResult Update(Policy policy);
        IResult Delete(Policy policy);
    }
}
