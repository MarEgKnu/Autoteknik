using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Owner : Person
    {
        public string Title { get; set; }

        public Owner(string name, string phone, string title) : base(name, phone)
        {
            Title = title;
        }
        public override string ToString()
        {
            return base.ToString() + $", Title: {Title}";
        }

        public override string IdInfo()
        {
            return $"{Id}Owner";
        }
    }
}
