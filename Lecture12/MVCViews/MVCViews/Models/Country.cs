﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCViews.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}