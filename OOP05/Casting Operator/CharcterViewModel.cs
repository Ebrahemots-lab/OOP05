using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Casting_Operator
{
    internal class CharcterViewModel
    {
        public string? Name { get; set; }

        public int Health { get; set; }

        public static explicit operator CharcterViewModel(Charcter charcter) 
        {
            return new CharcterViewModel
            {
                Name = charcter.Name ?? "Hero",
                Health = charcter?.Health ?? 0,
            };
        }

        public override string ToString()
        {
            return $"Name: {Name} - Health: {Health}";
        }
    }
}
