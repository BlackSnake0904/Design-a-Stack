using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_Stack
{

    public class Zasobnik
    {

        public readonly List<int> ListObjektov = new List<int>();

       

        public void Push(int obj)
        {

            ListObjektov.Add(obj);

        }

        public int Pop()
        {

            if (ListObjektov.Capacity >= 1)
            {
                var pom = ListObjektov[ListObjektov.Count - 1];
                ListObjektov.RemoveAt(ListObjektov.Count - 1);
                return pom;
            }
            else
            {
                throw new InvalidOperationException("Zasobnik je prazdny");

            }





        }
    }
}



