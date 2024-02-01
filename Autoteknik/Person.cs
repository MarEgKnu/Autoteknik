using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public abstract class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        private static int _counter = 0;

        public Person(string name, string phone)
        {
            _counter++;
            Id = _counter;
            Name = name;
            Phone = phone;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Phone: {Phone}, ID: {Id}";
        }
        public abstract string IdInfo();
    }
}
