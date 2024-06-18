using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Shipment
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public double Weight { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
    }
}
