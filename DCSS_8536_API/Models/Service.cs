﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCSS_8536_API.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ServiceCategory { get; set; }
        public decimal Price { get; set; }
    }
}
