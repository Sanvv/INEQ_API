using INEQ_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ_API.Models
{
    public class Component
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }

        //Claves foráneas
        public int ComponentTypeID { get; set; }
        public int EquipmentID { get; set; }
        public int EquipmentTypeID { get; set; }
        
        public virtual ComponentType ComponentType { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
    }
}