using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class City:IEntity
    {
        [Key] public int cityId {  get; set; }   
        public string cityName { get; set; }

    }
}
