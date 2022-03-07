using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        class c1
        {
            int a, b;
            public c1(int x, int y) //parmeterised constructor
            {
                this.a = x;
                this.b = y;
            }
            public void display()
            {
                Console.WriteLine("Value of a: {0}", a);
                Console.WriteLine("Value of b: {0}", b);
            }
        }
        static void Main(string[] args)
        {
            c1 ob1 = new c1(10, 20);
            ob1.display();
            Console.ReadLine();
        }



        // ---------------Copy Constructor------
        class Demo
        {
            string name;
            int age;
            public Demo(string name, int age) //paramertrized constructor
            {
                this.name = name;
                this.age = age;
            }
            public Demo(Demo d) //copy constructor
            {
                this.name = d.name;
                this.age = d.age;
            }
            public void getData()
            {
                Console.WriteLine("Name is:{0}", name);
                Console.WriteLine("Age is:{0}", age);
            }
        }
        //main method
        static void Main(string[] args)
        {
            Demo obj = new Demo("Sahithi", 20);
            obj.getData();
            Demo obj1 = new Demo(obj); //new object
            obj1.getData();
            Console.ReadLine();
        }

        //---Static Constructor-----------

        public static void Main()
        {
            Home home1 = new Home();
            Home home2 = new Home();
            Console.ReadLine();
        }

        class Home
        {
            static Home()
            {
                Console.WriteLine("From static constructor");
            }
            public Home()
            {
                Console.WriteLine("From default constructor");
            }
        }






    }
    
}
