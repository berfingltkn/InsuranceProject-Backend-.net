using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int user_id { get; set; }
        public string tc_no { get; set; }
        public string name { get; set; }
        public string surname {  get; set; }
        public string mail { get; set; }
        public string phone_no { get; set; }
        public int weight {  get; set; }
        public int height {  get; set; }
        public bool declaration { get; set; }
        public bool marketing_authorization {  get; set; }

    }
}
