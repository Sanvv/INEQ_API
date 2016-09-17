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
        public ComponentType ComponentType { get; set; }

        public int EquipmentID { get; set; }
        public Equipment Equipment { get; set; }

        public int EquipmentTypeID { get; set; }
        public EquipmentType EquipmentType { get; set; }

        public ICollection<ComponentType> ComponentTypes { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
        public ICollection<EquipmentType> EquipmentTypes { get; set; }  
    }
}