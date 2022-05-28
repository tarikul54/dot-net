using System;

namespace Calculator_1
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine(" WELLCOME TO CALCULATOR");
                Console.Write("\n Enter Your First Number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Enter Your Second Numeber : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n 1.For Addition(+) Type : 1,\n 2.For Subtraction(-) Type : 2,\n 3.For Multiplication(*) Type : 3,\n 4.For Division(/) Type : 4 ,\n 5.For Remender(%) Type : 5 ");
                Console.Write("\n Enter Your Operator Number : ");
                int time = Convert.ToInt32(Console.ReadLine());

                if (time == 1)
                {
                    Console.WriteLine("\n Result = " + (num1 + num2));
                }
                else if (time == 2)
                {
                    Console.WriteLine("\n Result = " + (num1 - num2));
                }
                else if (time == 3)
                {
                    Console.WriteLine("\n Result = " + (num1 * num2));
                }
                else if (time == 4)
                {
                    Console.WriteLine("\n Result = " + (num1 / num2));
                }
            else if (time == 5)
            {
                Console.WriteLine("\n Result = " + (num1 % num2));
            }
            else
                {
                Console.WriteLine("\n Your Selected Operator  is wrong\n Please Type 1 for Addition, 2 For Subtraction, 3  For Multiplication, 4 For Division, 5 Remender");
                }
         
            }            
        }
    }


    

