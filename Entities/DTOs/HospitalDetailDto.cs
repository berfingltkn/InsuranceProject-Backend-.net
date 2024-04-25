using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HospitalDetailDto:IDto
    {

        public string hospitalName { get; set; }
        public int districtID { get; set; }
        public string districtName { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
    }
}
