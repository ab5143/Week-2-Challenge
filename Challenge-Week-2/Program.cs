using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Week_2

{
    public class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();


            Greeter isGood = new Greeter();


            Console.Clear();

            string greetingDisplay = isGood.Greeting(name);
            Console.WriteLine(greetingDisplay);

            // Console.WriteLine(isGood.Greeting(name));
            //

            isGood.GreetingTime(name);

            Console.ReadLine();



        }

    }

    public class Greeter
    {

        public string Greeting(string name)
        {
            //string helloJoshua = "Joshua";

            // string Name = "Joshua";
            string greeting = $"Hello " + name;
            return greeting;
            // Console.WriteLine("Hello + {Name});
        }

        public void GreetingTime(string name)
        {

           if (DateTime.Now.Hour < 10)
            {
                Console.WriteLine("Good Morning");
            }

           else if (DateTime.Now.Hour >= 10 && DateTime.Now.Hour <=14)
            {
                Console.WriteLine("Good Afternoon");
            }

           else if (DateTime.Now.Hour >= 14 && DateTime.Now.Hour <= 21)
            {
                Console.WriteLine("Good Evening");
            }

            else 
            {
                Console.WriteLine("Please hit the sack!");
            }



        }




    }
    
    





}




    


