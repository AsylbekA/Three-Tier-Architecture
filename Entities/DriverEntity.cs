﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class DriverEntity:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
