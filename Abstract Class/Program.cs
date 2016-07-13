using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        public delegate void Myprint(string name); // delegate

        static void Morning(string name)
        {
            Console.WriteLine("Morning " + name);
        }

        static void Evening(String name)
        {
            Console.WriteLine("Evening " + name);
        }


        static void Main(string[] args)
        {
            Myprint mp = new Myprint(Morning);
            mp += Evening;
            //mp -= Morning;
            //mp("Quan");
            foreach(Delegate d in mp.GetInvocationList())
            {
                if(d.Method.Name.Equals("Morning")) {
                    d.DynamicInvoke(new object[] { "Quan" });
                }else d.DynamicInvoke(new object[] { "Nam" });
            }

            Console.ReadLine();
        }

       
    }
}
