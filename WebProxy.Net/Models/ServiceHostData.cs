﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProxy.Models
{
    public class ServiceHostData
    {
        public string Name { get; set; }

        public MicroServiceRandomObject[] Hosts { get; set; }
    }
}