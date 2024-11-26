using ClassTypes231124.Sealed_Class;
using myNamespace;
using System.Security.Cryptography.X509Certificates;

namespace ClassTypes231124
{
    class outerclass
    {
        
        public void outerMethod()
        {
            innerclass obj = new innerclass();
            obj.innerMethod();
       
        }
        private class innerclass
        {
            
            public void innerMethod()
            {
                st1 = 22;
                Console.WriteLine("inner class method!!!");
                outerclass o=new outerclass();
                o.outerMethod();
            }

        }
    }
    
    internal partial class temp
    {
       static temp tt ;
        private temp()
        {
            Console.WriteLine("object created !!!"); 
        }
        int var1;
        
       static public temp TempMethod()
        {
            if (tt==null)
            {
             tt = new temp();
            }
             //valid
            return tt;
        }
    }
    partial class class1
    {
        private int x;
        public void metho1()
        {
            x = 111;
            Console.WriteLine("method 1 called..");
        }
        public void method1(int x)
        {
            int z = x;

            Console.WriteLine("method 1 with 1 parameter.");
        }
    }
  partial  class class1
    {
     public void method3()
        {
            int p = x;

        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //class1 obj = new class1();
            //obj.method3();
            // temp t1=new temp();
            //  t1.TempMethod();
            // t1.sum(11, 22);

            //temp tt = new temp(22);

            //temp t1=  temp.TempMethod();
            //  t1.sum(11, 22);
            //  temp t2 = temp.TempMethod();
            //  t2.sum(1, 2);
            //  Console.WriteLine(object.ReferenceEquals(t1,t2));


            //classCC obj = new classCC();
            //obj.newMthod();

            // outerclass.innerclass obj = new outerclass.innerclass();
            outerclass obj11 = new outerclass();
            obj11.outerMethod();

           
        }
    }
}
