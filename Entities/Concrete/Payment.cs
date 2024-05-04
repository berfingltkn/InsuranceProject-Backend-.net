using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Payment:IEntity
    {
        [Key] public int paymentId { get; set; }
        public int userId {  get; set; }
        public int policyId { get; set; }
        public string nameOnCart { get; set; }
        public string surnameOnCart {  get; set; }
        public string cartNumber {  get; set; }
        public string dateCart {  get; set; }
        public string paymentType {  get; set; }
        public bool approvalInformationForm {  get; set; }
        public bool approvalSellingContract {  get; set; }
        public bool approvalInformationalText {  get; set; }

    }
}
