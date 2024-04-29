using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Coverage:IEntity
    {
        [Key] public int offerNo {  get; set; }
        public string coverageType { get; set; }
        public int amount { get; set; }
    }
}
