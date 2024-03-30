using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advanced_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello FN = {0} LN = {0}","Pan","Sud");//ตำแหน่งการดำเนินการภายใต้ปีกกา

             // int
             int x = 10;
             int y = 20;

             //float
             float a = 20f;

             //double
             double number1;
             number1 = x+y;

             //boolean
             bool status = true;

             //char& string
             char al = 'A';
             string name = "pompam";

             //ตัวแปรค่าคงที่ 
             const float PI = 3.14f;
             const int SIZE = 2000;

             Console.WriteLine(name);

             //format string สำหรับการแสดงผลตัวเลข
             int number = 12000;
             Console.WriteLine("Number ={0}", number);
             Console.WriteLine("Number ={0:E}", number);
             Console.WriteLine("Number ={0:F4}", number);
             Console.WriteLine("Number ={0:G}", number);
             Console.WriteLine("Number ={0:N}", number);
             Console.WriteLine("Number ={0:P}", number);
             Console.WriteLine("Number ={0:X}", number);
             Console.ReadLine();

             //Console.Write("Input: ");//
             // Read & ReadLine
             //int result = Console.Read(); //สร้างตัวแปรไว้เก็บค่า อ่านค่า Read ตัวอักษร
             //string result2 = Console.ReadLine(); // ไว้รับข้อความยาวให้ใช้ Readline
             //Console.WriteLine(result); //แสดงผลออกทางหน้าจอ
             //Console.WriteLine(result2);

             //ตัวดำเนินการทางคณิตศาสตร์
             int p = 10;
             int o = 5;
             Console.WriteLine("pom = {0}",p+o);                 

            //ฟังก์ชั่นทางคณิตศาสตร์
            float number = 15.49f;
            Console.WriteLine("Abs = {0}",Math.Abs(number));
            Console.WriteLine("Ceiling = {0}", Math.Ceiling(number));
            Console.WriteLine("Floor = {0}", Math.Floor(number));
            Console.WriteLine("Round = {0}", Math.Round(number));
            Console.WriteLine("Power = {0}", Math.Pow(number,2)); //5 ยกกำลัง 2 = (5,2)
            Console.WriteLine("Square = {0}", Math.Sqrt(number));
            Console.WriteLine("PI = {0:F3}", Math.PI);
            Console.WriteLine("E = {0}", Math.E);              

            //ตัวดำเนินการเปรียบเทียบ
            int number1 = 50, number2 = 100;
            Console.WriteLine(number1 == number2);
            Console.WriteLine(number1 != number2);
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 < number2);
            Console.WriteLine(number1 >= number2);
            Console.WriteLine(number1 <= number2);    

            int a = 5, b = 10;
            //เพิ่มค่า
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("prefix = {0}",++a);
            Console.WriteLine("posfix = {0}",a++);
            Console.WriteLine("a = {0}", a);

            //ลดค่า
            Console.WriteLine("b = {0}", b);
            //Console.WriteLine("prefix = {0}",--b);
            Console.WriteLine("posfix = {0}", b--);
            Console.WriteLine("b = {0}", b);           

            //convert
            string myString = "120";

            //แปลงข้อความเป็นตัวเลข
            byte myByte = Convert.ToByte(myString);
            short myShort = Convert.ToInt16(myString);
            int myInt = Convert.ToInt32(myString);
            long myLong = Convert.ToInt64(myString);
            //ทศนิยม
            float myFloat = Convert.ToSingle(myString);
            double myDouble = Convert.ToDouble(myString);
            string result = Convert.ToString(myString);

            Console.WriteLine("string = {0}",myString);
            Console.WriteLine("byte = {0}", myByte);
            Console.WriteLine("short = {0}", myShort+13);
            Console.WriteLine("int = {0}", myInt);
            Console.WriteLine("long = {0}", myLong);
            Console.WriteLine("float = {0}", myFloat);
            Console.WriteLine("double = {0}", myDouble);
            Console.WriteLine("double tostring = {0}", result);       

            //Parse
            //input
            string myString = "222";
            //process
            byte myByte = Byte.Parse(myString);
            short myShort = short.Parse(myString);
            int myInt = Int32.Parse(myString);
            long myLong = long.Parse(myString);
            float myFloat = float.Parse(myString);
            double myDouble = double.Parse(myString);
            //output
            Console.WriteLine("string = {0}",myString+111);
            Console.WriteLine("byte = {0}", myByte);
            Console.WriteLine("short = {0}", myShort);
            Console.WriteLine("int = {0}", myInt);
            Console.WriteLine("long = {0}", myLong);
            Console.WriteLine("float = {0}", myFloat);
            Console.WriteLine("double = {0}", myDouble);        */

            /*
            //tryparse
            //input
            string myString = "200";
            //process
            int myInt;
            bool success = int.TryParse(myString,out myInt);
            //long myLong = long.Parse(myString);
            //float myFloat = float.Parse(myString);
            //double myDouble = double.Parse(myString);
            //output
            Console.WriteLine("string = {0}", success);
            Console.WriteLine("int = {0}", myInt);
            //Console.WriteLine("long = {0}", myLong);
            //Console.WriteLine("float = {0}", myFloat);   */

            /*
            //norowwing
            double x = 100.15;
            int y = (int)x;
            Console.WriteLine(y);

            //widenning
            float a = 200f;
            double b = (float)a;
            Console.WriteLine(b);        */

            /*
            //โปรแกรมคำนวณค่า Bmi
            //กรอกค่า
            Console.Write("Input height(m.) :");
            float height2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input weight(kg.) :");
            float weight2 = Convert.ToSingle(Console.ReadLine());

            //แสดงผลการกรอก
            Console.WriteLine("ส่วนสูง : {0} เมตร",height2);
            Console.WriteLine("น้ำหนัก : {0} เซนติเมตร", weight2);

            //คำนวณ
            float Bmi;
            Bmi = weight2 /(height2 * height2) ;

            //แสดงการคำนวณ
            Console.WriteLine("Bmi : {0} ",Bmi);
            Console.WriteLine("Number ={0}", Bmi);
            Console.WriteLine("Number ={0:E}", Bmi);
            Console.WriteLine("Number ={0:F4}", Bmi);
            Console.WriteLine("Number ={0:G}", Bmi);
            Console.WriteLine("Number ={0:N}", Bmi);
            Console.WriteLine("Number ={0:P}", Bmi);    */

            /*
             //การใช้เงื่อนไขหลายเงื่อนไข
             int score ;
             Console.Write("Input Your Score : ");
             int.TryParse(Console.ReadLine(), out score);
             if (score>=80 && score <=100)
             {
                 Console.WriteLine("A");
             }
             else if (score >= 70 && score <=79)
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
             else if (score < 50 && score >=0){ 
                 Console.WriteLine("F: so you can study again GO!!!!");
             }
             else
             {
                Console.WriteLine("Get Out!!! Can't Find Information");
             }
            */

            /*
            //การใช้ตัวดำเนินการทางตรรกศาสตร์
            int height;
            Console.Write("Input Your height(cm.) : ");
            int.TryParse(Console.ReadLine(), out height);
            Console.Write("Input Your sex (male/female) : ");
            string sex = Console.ReadLine();

            if (sex == "male" && height >= 160) //และ
            {
                Console.WriteLine("ผ่านเกณฑ์");
            }
            else if ( sex == "male" || height >= 160) //หรือ
            {
                Console.WriteLine("ผ่านเกณฑ์");
            }            
            else
            {
                Console.WriteLine("ไม่ผ่านเกณฑ์");
            }
            */

            /*//ternary operater
            int score = 40;
            string result;
            result = (score >= 50) ?  "Pass" : "Not Pass";

            Console.WriteLine("Status = {0}",result);    */

            /*//เงื่อนไขในเงื่อนไข
            int money,result;
            Console.Write("Input amount : ");
            int.TryParse(Console.ReadLine(), out money);

            if (money >= 15000)
            {
                if (money >=15000 &&  money <20000)
                {
                    result = money - ((money * 10) / 100);
                    Console.WriteLine("money : {0:N1}", result);
                }
                else if (money >= 20000 && money < 30000)
                {
                    result = money - ((money * 20) / 100);
                    Console.WriteLine("money : {0:N1}", result);
                }
                else if (money >= 30000 )
                {
                    result = money-((money * 30) / 100);
                    Console.WriteLine("money : {0:N1}", result);
                }

            }
            else {
                Console.WriteLine("Don't have discount");

            }     
            */

            /*//switch case
            int num1, num2,select,answer;
            Console.Write("Input number1 : ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Input number2 : ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.Write("Select 1(+) or 2(-) : ");
            int.TryParse(Console.ReadLine(), out select);

            switch (select)
            {
                case 1:answer = num1 + num2;
                    Console.WriteLine("Answer : {0}",answer); 
                    break;
                case 2:answer = num1 - num2;
                    Console.WriteLine("Answer : {0}", answer);
                    break;
                default: Console.WriteLine("Error!!");
                    break;
            }
               */

            /*//while loop 
            int count = 1;
            int num;
            Console.Write("Input Number : ");
            int.TryParse(Console.ReadLine(), out num);
            while (count<=13)
            {
                //คำสั่งที่ต้องการให้ทำซ้ำ
                Console.WriteLine("{0} * {1} = {2}",num,count,num*count);
                count++;//จำนวนรอบพี่บวกเพิ่มขึ้น
            }*/


            /*//forloop
            int num;
            Console.Write("Input Number : ");
            int.TryParse(Console.ReadLine(), out num);
                for (int i = 1; i < 12; i++)
                {
                    Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
                }*/

            /*  //สูตรคูณป๋อมแป๋ม
               int num;
               Console.Write("Input Number : ");
               int.TryParse(Console.ReadLine(), out num);
                  for(int j=1;j<=num; j++ )
                  {  
                    for (int i = 1; i < 12; i++)
                         {
                             Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
                         }
                  }*/

            //while
            /*int count = 4;
            while (count > 3) 
            {
                Console.WriteLine("Hello = {0}", count);
                count++;
            }
            Console.WriteLine("End");*/

            //do..while
            /*int count = 1;
            do
            {
                Console.WriteLine("Hello = {0}", count);
                count++;
            } while (count <= 3) ;
            Console.WriteLine("End"); */

            //break & continue
            //forloop
            /*int num;
            Console.Write("Input Number : ");
            int.TryParse(Console.ReadLine(), out num);
                for (int i = 1; i < 12; i++)
                {
                    if(i==10)
                    {
                        break;
                    }
                    Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
                }
            Console.WriteLine("End  */

            /*//Ex.1
             int num1,num2,num3,num4,num5,sum,arg;
            Console.Write("Input number1 : ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Input number2 : ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.Write("Input number3 : ");
            int.TryParse(Console.ReadLine(), out num3);
            Console.Write("Input number4 : ");
            int.TryParse(Console.ReadLine(), out num4);
            Console.Write("Input number5 : ");
            int.TryParse(Console.ReadLine(), out num5);

            sum = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine("summation = {0}",sum);

            arg = sum / 5;
            Console.WriteLine("average = {0}", arg);

            Console.ReadKey(); */


            /*int num, avg ;
            int sum = 0 ;
                for (num=5; num <=10; num++)
            {
                sum += num;
            }
            Console.WriteLine("summation : {0} ",sum);
            avg =sum / 5;
            Console.WriteLine("average : {0} ",avg);
            */



            /*
            //Ex.2
            float sum = 0, avg,n;
            int i=0;
            while (true)
            {
                Console.Write("Input Number : ");
                float.TryParse(Console.ReadLine(), out n);
                if (n < 0) 
                {
                    break;
                }
                sum += n;
                i++;
            }
            Console.WriteLine("summation : {0} ", sum);
            avg = sum/i;
            Console.WriteLine("average : {0} ", avg);
            */

            //Ex.4
            int money;
            do
            {
                Console.Write("Input Money = ");
                int.TryParse(Console.ReadLine(), out money);
            }while((money%100 !=0) || money>=20000);//เช็คเงินว่าเป็นหลักหน่วยหรือหลักสิบ

            Console.WriteLine("Money = {0}",money);
            Console.WriteLine("1000 Baht = {0}",money/1000);
            money %= 1000;
            Console.WriteLine("500 Baht = {0}",money/500);
            money %= 100;
            Console.WriteLine("100 Baht = {0}",money/100);
            Console.ReadKey(); 
        }
    }
}