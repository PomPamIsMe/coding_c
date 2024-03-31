using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Program_testing_with_jira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Ex.1
            Console.WriteLine("Hello World");  */

            /*//Ex.2
            int number;

            Console.Write("Input : ");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 0; i < number; i++) 
            {
                for (int j = 0; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }  */

            /* //Ex.3
            int score;

            Console.Write("");
            int.TryParse(Console.ReadLine(), out score);

            if (score >= 80 && score <= 100)
            {
                Console.WriteLine("A");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("B");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("C");
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("F");
            }

            Console.ReadKey(); */

            /* //Ex.4
            int a, b;

            Console.Write("Input : ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Input : ");
            int.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("{0}",a+b);

            Console.ReadKey();  */

            /* //Ex.5
            int a, b;

            Console.Write(""); 
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("");
            int.TryParse(Console.ReadLine(),out b);

            if (a > b)
            {
                Console.WriteLine("A");
            }
            else if (b > a)
            {
                Console.WriteLine("B");
            }
            else { Console.WriteLine("AB"); }

            Console.ReadKey();  */

            /*//Ex.6
            Console.WriteLine("Welcome to Sommai 108 Eleven Shop");

            Console.ReadKey(); */

            /*//Ex.7
            int i, j;

            for (i = 0; i < 6; i++)
            {
               for (j = 0; j <= i;j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey(); */

            /*//Ex.8
           
            for(int i= 1; i <= 5; i++) // แสดงแถว
            {
                for(int j = 5; j > i ; j--) //แสดงช่องว่างก่อน output
                {
                    Console.Write(" ");
                }
                for (int s = 1; s <= i; s++) //แสดง output ที่เป็นพิระมิด $
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();  */

            /*//Ex.9
            string name;

            Console.Write("");
            name = Console.ReadLine();

            Console.WriteLine("Welcome {0} !",name);
            Console.WriteLine("Sommai 108 Eleven Shop");
            Console.ReadKey(); */

            /*//Ex.10
            int num1,num2;

            Console.Write("");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("");
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

            Console.ReadKey(); */

            /*//Ex.11
            int Hr, Km,answer;

            Console.Write("km :");
            int.TryParse(Console.ReadLine(), out Km);
            Console.Write("hr. :");
            int.TryParse(Console.ReadLine(), out Hr);

            answer = Km / Hr;

            Console.WriteLine("{0} km/h",answer);
            Console.ReadKey();  */

            /*//Ex.12
            int product, price, total;
            Console.Write("");
            int.TryParse(Console.ReadLine(), out product);
            Console.Write("");
            int.TryParse(Console.ReadLine(), out price);

            total = product * price;

            Console.WriteLine(total);
            Console.ReadKey();  */

            /*//Ex.13
            int num1, num2, answer;
            Console.Write("");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("");
            int.TryParse(Console.ReadLine(), out num2);

            answer = num1 % num2;

            Console.WriteLine(answer);
            Console.ReadKey();   */

            /*//Ex.14
            int num1, num2,max=0,min=0;
            Console.Write("");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("");
            int.TryParse(Console.ReadLine(), out num2);

            if (num1>num2)
            {
                max = num1;
                min = num2;
            }
            else if(num1<num2) 
            {
                min = num1;
                max = num2;
            }
 

            Console.WriteLine("MAX : {0}", max);
            Console.WriteLine("MIN : {0}", min);

            Console.ReadKey(); */

            /*//Ex.15
            string name;
            int year;

            Console.Write("");
            name = Console.ReadLine();
            Console.Write("");
            int.TryParse(Console.ReadLine(), out year);

            if (year <= 2003)
            {
                Console.WriteLine("welcome {0} to NongGipsy Pub", name);
            }
            else if(name == "A")
            {
                Console.WriteLine("You shall not pass!");
            }
            else
            {
                Console.WriteLine("You shall not pass!");
            }
            Console.ReadKey();  */

            /*//Ex.16
            int a;

            Console.Write("");
            int.TryParse(Console.ReadLine(), out a);

            for(int i = 0; i < a; i++) 
            {
                Console.WriteLine("A");
            }
            Console.ReadKey();*/

            /*//Ex.17
            int step;

            Console.Write("");
            int.TryParse(Console.ReadLine(), out step);

            for (int i = 1; i <= step; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey(); */

            /*//Ex.18
            int step,count=1; //ใช้ count เพื่อเพิ่มจำนวนรอบของ for s

            Console.Write("");
            int.TryParse(Console.ReadLine(), out step); 

            for(int i = 1; i <= step; i++)
            {
                for(int j = step; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= count; k++)
                {
                    Console.Write("*");
                }
                count += 2;
                Console.WriteLine();    
            }
            Console.ReadKey();  */

            /*//Ex.19
            double answer;

            Console.Write("num1 :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("num2 :");
            double num2 = Convert.ToDouble(Console.ReadLine());

            answer = Math.Pow(num1 ,num2);

            Console.WriteLine(answer);

            Console.ReadKey(); */

            /*//Ex.20
            int year;

            Console.Write("year : ");
            int.TryParse(Console.ReadLine(), out year);

            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                {
                    Console.WriteLine("Leap Year");
                }
                else if (year % 100 == 0)
                {
                    if (year % 400 != 0)
                    {
                        Console.WriteLine("Not a Leap Year");
                    }
                    else { Console.WriteLine("Leap Year"); }
                }
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }  
            
            Console.ReadKey();  */

            //Ex.21
            int wide;

            Console.Write("");
            int.TryParse(Console.ReadLine(), out wide);

            for(int i = 1; i <= wide; i++)
            {
                if(i == 1 || i == wide) 
                {
                    for (int j = 1; j <= wide; j++)
                    {
                        Console.Write("#");
                    }
                }
                else
                {
                    Console.Write("#");
                    for (int j = 1; j <= wide-2 ; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("#");
                }


                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}