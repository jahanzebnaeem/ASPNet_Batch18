using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUIMVC.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50), MinLength(3)]
        public string Name { get; set; }

        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }
}