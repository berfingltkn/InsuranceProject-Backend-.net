using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hospital:IEntity
    {
        public int cityID {  get; set; }
        public int districtID { get; set; }

       [Key] public string hospitalName { get; set; }
    }
}
