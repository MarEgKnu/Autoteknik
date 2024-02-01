using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Mechanic : Person
    {
        public string Education { get; set; }
        public Mechanic(string name, string phone, string education) : base(name, phone)
        {
            Education = education;
        }
        public override string ToString()
        {
            return base.ToString() + $", Education: {Education}";
        }

        public override string IdInfo()
        {
            return $"{Id}Internal";
        }
    }
}
