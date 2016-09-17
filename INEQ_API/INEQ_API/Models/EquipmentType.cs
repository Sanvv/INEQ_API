using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ_API.Models
{
    public class EquipmentType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public float UserfulLife { get; set; }
        public float GuaranteeDuration { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<EquipmentType> EquipmentTypes { get; set; }

    }
}