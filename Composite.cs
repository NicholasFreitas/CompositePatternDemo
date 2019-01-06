using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite : IComponent
    {
        List<IComponent> Leaves;

        public Composite(List<IComponent> leaves)
        {
            Leaves = leaves;
        }

        public void Operation()
        {
            Console.WriteLine("Composite");
            foreach (var leaf in Leaves)
            {
                leaf.Operation();
            }
        }
    }
}
