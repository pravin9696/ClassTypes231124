using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypes231124.Sealed_Class
{
   sealed internal class ClassAA
    {
        public void methodA1()
        {
            Console.WriteLine("method 1 from classAA");
        }
    }
    class classBB
    {
        public void newMthod()
        {
            ClassAA objA = new ClassAA();
            objA.methodA1();
        }
        public void methodB1()
        {

            Console.WriteLine("method 1 from classBB");
        }
    }
    class classCC : classBB
    {
        public void methodA1()
        {
            Console.WriteLine("dfasfdsafasfq23142");
        }
        public void methodC1()
        {
            Console.WriteLine("method 1 from classCC");
        }
    }
}
