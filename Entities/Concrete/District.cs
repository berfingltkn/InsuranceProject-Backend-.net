using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class District:IEntity
    {
       [Key] public int districtId {  get; set; }
        public string districtName { get; set; }
    }
}
