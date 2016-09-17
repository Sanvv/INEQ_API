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

        //Clave Foránea
        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
    }
}