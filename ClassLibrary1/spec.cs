using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp5454
{
    class spec
    {
        private string name;
        private string reduction;

        public spec(spec name, spec reduction)
        {
            string Name;
            string Reduction;

            Name = this.name;
            Reduction = this.reduction;
            
            Console.WriteLine($"Название: {name} Сокращение: {reduction}");
        }
    }
}
