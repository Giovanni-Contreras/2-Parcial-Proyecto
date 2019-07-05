using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Singleton
    {
        private static Singleton instancia;
        private Singleton() { }
        public static Singleton getInstancia() {
            if (instancia==null) {
                instancia = new Singleton();
            }
            return instancia;
        }
    }
}
