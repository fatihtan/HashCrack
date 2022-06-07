using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class TypeValue
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public TypeValue(string Name, int Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}