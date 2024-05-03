using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Policy:IEntity
    {
        [Key] public int policyId { get; set; }
        public int customerIdNumber { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string policyType { get; set; }
        public DateTime createDate {  get; set; }
        public int totalAmount {  get; set; }

    }
}
