using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ_API.Models
{
    public class Warehouse
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string IS { get; set; } 
        public string Responsable { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}