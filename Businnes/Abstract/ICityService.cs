using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IResult Add(City city);
        IResult Update(City city);
        IResult Delete(City city);
        
    }
}
