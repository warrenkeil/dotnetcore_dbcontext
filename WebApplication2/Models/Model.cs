﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Model
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public Make Make { get; set; }
        public int MakeId { get; set; }

    }
}
