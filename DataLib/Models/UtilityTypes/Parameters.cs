using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Models
{
    public class Parameters
    {
        public int Pledge { get; set; }
        public string PaymentType { get; set; }
        public TimeSpan RentTime { get; set; }
        public int CostOfRent { get; set; }
    }
}
