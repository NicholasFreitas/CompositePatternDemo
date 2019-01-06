using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        /*
         
            It's sort of like a decorator pattern, but it appears the intent is sligthly different.
            While decorators aim to expand functionality, Composites tend to use recursion to get through
            a complex hierarchical tree structure.
                       

                           --------------
                           |IComponent  |
                           -------------- <-----has-a------|
                           |Operation() |                  |
                           --------------                  |
                                 ^                         |
                                 ^   is-a                  |
                                 |                         |
                                 |                         |
                  ____________________________             |
                  |                          |             |
            -------------             -------------        |
            |Leaf       |             |Composite  |        |
            |-----------|             |-----------| < >----|
            |Operation()|             |Operation()| 
            -------------             -------------
             
         */


        static void Main(string[] args)
        {
            var leaves1 = new List<IComponent>();
            leaves1.Add(new Leaf());
            leaves1.Add(new Leaf());
            leaves1.Add(new Leaf());

            var comp1 = new Composite(leaves1);
            //--------------------------------------           

            var leaves2 = new List<IComponent>();
            leaves2.Add(new Leaf());
            
            var comp2 = new Composite(leaves2);

            //-----------------------------------------

            var leaves3 = new List<IComponent>();
            leaves3.Add(comp1);
            leaves3.Add(comp2);

            var comp0 = new Composite(leaves3);

            //-----------------------------------------


            comp0.Operation();


        }
    }
}
