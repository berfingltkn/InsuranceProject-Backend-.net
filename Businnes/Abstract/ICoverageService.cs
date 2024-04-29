using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface ICoverageService
    {
        IDataResult<List<Coverage>> GetAll();
        IResult Add(Coverage coverage);
        IResult Update(Coverage coverage);
        IResult Delete(Coverage coverage);
    }
}
