using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAPI.Fundamentals
{
    internal abstract class Person
    {
        protected string Name { get; set; }
        protected int Ci { get; }

        public Person(string name, int ci)
        {
            this.Name = name;
            this.Ci = ci;
        }

        public string ReturnData()
        {
            return $"{this.Name} has {this.Ci} as C.I.";
        }

        public abstract string ShowYourWork();
    }
}
