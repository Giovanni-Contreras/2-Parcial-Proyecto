using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton singleton = new Singleton();

            Singleton singleton = Singleton.getInstancia();
            Singleton singleton2 = Singleton.getInstancia();
            if (singleton==singleton2) {
                Console.WriteLine("Es la misma instancia");
             
            }
            Otra otra = new Otra();
            Otra otra2 = new Otra();
            if (otra == otra2)
            {
                Console.WriteLine("Es la misma instancia");
            }
            else {
                Console.WriteLine("Es diferente instancia");
            }
            Console.ReadLine();
        }
    }
}
