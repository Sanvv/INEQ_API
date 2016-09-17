﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INEQ_API.Models
{
    public class ComponentType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<Component> Components { get; set; }
    }
}