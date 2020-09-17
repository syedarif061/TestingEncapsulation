using System;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Versioning;

namespace TestingEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
             CustomerInfo();
          
        }

        /************************************************/

        private static Person CustomerInfo()
        {
            Person c = new Person();
            int age;
            string fname;
            string lname;
            Console.WriteLine("Customer Info:");


           for (; ; )
            {
                Console.Write("Please Enter First name: ");
                fname = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(fname))
                {
                    throw new ArgumentException("First name can not be null or empty!");
                }
                int result = 0;
                while (int.TryParse(fname, out result))
                {
                    

                    Console.WriteLine("please write in Correct format" );
                Console.Write("Please Enter First name again: ");
                fname = Console.ReadLine();
                    
                }

                Console.Write("Please Enter Last name: ");
                lname = Console.ReadLine();
                while (int.TryParse(lname, out result))
                {

                Console.WriteLine("please write in Correct format");
                Console.Write("Please Enter  Last name again: ");
                lname = Console.ReadLine();

                }

                Console.Write("please enter age: ");
                var ageAsString = Console.ReadLine();
                while (!int.TryParse(ageAsString, out age))
                {

                Console.WriteLine("please write in Correct format");
                Console.Write("Please Enter age again: ");
                ageAsString = Console.ReadLine();

                }
               
                if (fname.Length > 2 && fname.Length <= 10) 
                
                {

                    if (lname.Length >= 3 && lname.Length <= 15) 

                    if (age > 0)
                    {
                            break;
                    }
                
                }


                //break;
                //else 
                //throw new ArgumentException("");


            }
               
            //Console.Write("Please Enter Customer First Weight: ");
            //int weight = int.Parse(Console.ReadLine());

            c.setFname(fname);
            c.setLname(lname);
           
            c.setAge(age);
            //c.setWeight(weight);


           
            //Console.WriteLine("First Name: " + c.getFname());
            //Console.WriteLine("Last Name: " + c.getLname());
              Console.WriteLine(c.getFname() + " " + c.getLname() + " age is " + c.getAge());
            //Console.WriteLine(c.getFname() + " " + c.getLname() + " weight is: " + c.getWeight());
            
            return c;
        }

        /************************************************/

        private static Person SalesmanInfo()
        {
            Person salesman = new Person();

            salesman.setAge(20);
            salesman.setFname("Sharmin");
            salesman.setLname("Ahmed");
            salesman.setWeight(56);

            string s_firstName = salesman.getFname();
            string s_lastName = salesman.getLname();
            int s_age = salesman.getAge();
            int s_weight = salesman.getWeight();

            Console.WriteLine("");
            Console.WriteLine("Salesman Info:");
            Console.WriteLine("First Name: " + s_firstName);
            Console.WriteLine("Last Name: " + s_lastName);
            Console.WriteLine(s_firstName + " " + s_lastName + " age is: " + s_age);
            Console.WriteLine(s_firstName + " " + s_lastName + " weight is: " + s_weight);



            return salesman;
        }
    }
}
