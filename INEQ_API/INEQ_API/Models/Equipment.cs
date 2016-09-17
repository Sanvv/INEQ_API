using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ_API.Models
{
    public class Equipment
    {
        public int ID { get; set; }
        public DateTime EntryDate { get; set; }
        public string Serie { get; set; }
        public int SofttekID { get; set; }
        public Boolean Active { get; set; }

        //Claves foránea
        public int EquipmentTypeID { get; set; }
        public EquipmentType EquipmentType { get; set; }

        public int ModelID { get; set; }
        public Model Model { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public int StatusID { get; set; }
        public Status Status { get; set; }

        public int WarehouseID { get; set; }
        public Warehouse Warehouse { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
         
    }
}