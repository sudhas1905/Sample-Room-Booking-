using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelmanegment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int M_AGE;
            String M_NAME;
            Console.WriteLine("WELCOME TO THE HOTEL ");
            Console.Write("ENETR YOUR NAME  :");
            M_NAME = Console.ReadLine();
            Console.Write("ENTER YOUR AGE   :");
            M_AGE = int.Parse(Console.ReadLine());
            if (M_AGE >= 18)
            {
                Console.WriteLine($"WELCOME MR/MS {M_NAME} SELECT YOUR ROOM");

                List<(String name, int age)> familymembars = new List<(String, int)>();


                while (true)
                {

                    Console.WriteLine("YOU HAVE ANY CHILDS OR FAMILY MEMBERS\n");
                    Console.WriteLine("Yes / No ENTER A SMALL LETTER");
                    Console.WriteLine("IF YOU WANT TO SEE EENTERED DETAILS ENTER 'Show'\n");
                    string opt = Console.ReadLine().ToLower().Trim();

                    switch (opt)
                    {
                        case "yes":
                            Console.Write("ENTER A FAMILY MEMBERS NAME  :");
                            string F_NAME = Console.ReadLine();
                            Console.Write("ENTER A FAMILY MEMBERS AGE  :");
                            int F_AGE = int.Parse(Console.ReadLine());

                            familymembars.Add((F_NAME, F_AGE));
                            break;

                        case "show":

                            Console.WriteLine($"BOOKING CUSTUMER  NAME  :{M_NAME}");
                            Console.WriteLine($"BOOKING CUSTUMER AGE   :{M_AGE}\n");
                          

                            Console.WriteLine("FAMILY MEMBERS (ABOVE 18)");
                            foreach (var MEMBER in familymembars)
                            {
                                if (MEMBER.age >= 18)

                                {
                                    Console.WriteLine($"NAME  :{MEMBER.name}\nAGE  :{MEMBER.age}\n");
                                }
                            }

                            Console.WriteLine("FAMILY MEMBERS (BELOW 18)");

                            foreach (var MEMBER in familymembars)
                            {
                                if (MEMBER.age < 18 || MEMBER.age>10 )
                                {
                                    Console.WriteLine($"NAME  :{MEMBER.name}\nAGE  :{MEMBER.age}\n");
                                }
                            }
                            Console.WriteLine("Below 10 years childs no fee");
                            foreach(var member in familymembars)
                            {
                                if(member.age <=10)
                                {
                                    Console.WriteLine($"NAME  :{member.name}\nAGE  :{member.age}");
                                }
                            }



                            break;


                        case "no":

                            Console.WriteLine("BOOKING SUCCFULLY");

                            return;

                        default:

                            Console.WriteLine("INVALID OPTION. PLEASE ENTER 'Yes', 'Show', OR 'No'.");
                            break;
                    }



                }

            }
            else
            {
                Console.WriteLine("YOU ARE UNDER 18 DEOSN'T BOOK ");
            }


        }
    }
}
