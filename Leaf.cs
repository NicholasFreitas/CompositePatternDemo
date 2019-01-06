using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Leaf : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Leaf");
        }
    }
}
