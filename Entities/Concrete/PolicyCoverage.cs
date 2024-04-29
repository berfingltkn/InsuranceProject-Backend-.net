using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PolicyCoverage:IEntity
    {
        [Key] public int ID { get; set; }
        public int policyID {  get; set; }
        public int offerNO { get; set; }
    }
}
