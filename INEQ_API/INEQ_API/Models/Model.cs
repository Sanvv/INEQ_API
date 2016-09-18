using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ_API.Models
{
    public class Model
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }

        //Claves Foráneas
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
    }
}