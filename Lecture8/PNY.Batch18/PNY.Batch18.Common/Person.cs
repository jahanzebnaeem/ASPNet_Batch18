using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNY.Batch18.Common
{
    public abstract class Person
    {
        public int CNIC { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public Address CurrentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public List<ContactNumber> ContactNumbers { get; set; }
    }
}
