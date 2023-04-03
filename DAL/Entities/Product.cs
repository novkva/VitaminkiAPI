using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Calories { get; set; }
        public List<Vitamin> Vitamins { get; set; }
    }
}
