using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_lesson6_part_2
{
  public   class Product
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Cost { get; set; }


        public override string ToString()
        {
            return $@"Name:{Name}
                    Country{Country}
                       Cost{Cost}";
        }
    }
  
}
