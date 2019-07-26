using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.AvoidFatStack
{
    public class Controller
    {
        public static Action Next;

        internal static void Start()
        {
            while (Next!=null)
            {
                Next();
            }
        }
    }
    public class App
    {
       
        internal void Run()
        {
            Controller.Next = A;
            Controller.Start();
        }

        private void A()
        {
            Console.WriteLine("Here is A");
            Controller.Next = B;
        }

        private void B()
        {
            Console.WriteLine("Here is B");
            Controller.Next = C;
        }

        private void C()
        {
            Console.WriteLine("Here is C");
            Controller.Next = null;
        }
    }
}
