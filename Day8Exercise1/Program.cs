using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Excercise1
{
    public delegate void SpinVal(int a, int b);
    public class Program
    {
        static void Main(string[] args)
        {
            SpinClass obj = new SpinClass(); 

            int energy = 0; 
            int winprob = 0;

            SpinVal spinvalue = new SpinVal(obj.TenthSpin);
            spinvalue -= obj.TenthSpin;

            string name; 
            int LuckyNum;
            Console.WriteLine("Enter you Name :");
            name = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Lucky Number between 1-10 :");
                LuckyNum = int.Parse(Console.ReadLine());

                switch (LuckyNum)
                {
                    case 1: 
                        spinvalue += obj.FirstSpin; 
                        break;
                    case 2:
                        spinvalue += obj.SecondSpin; 
                        break;
                    case 3:
                        spinvalue += obj.ThirdSpin; 
                        break;
                    case 4:
                        spinvalue += obj.FourthSpin; 
                        break;
                    case 5:
                        spinvalue += obj.FifthSpin; 
                        break;
                    case 6:
                        spinvalue += obj.SixthSpin; 
                        break;
                    case 7:
                        spinvalue += obj.SeventhSpin; 
                        break;
                    case 8:
                        spinvalue += obj.EighthSpin; 
                        break;
                    case 9:
                        spinvalue += obj.NinthSpin; 
                        break;
                    case 10:
                        spinvalue += obj.TenthSpin; 
                        break;
                    default: Console.WriteLine("Invalid Lucky Number!!!"); 
                        break;
                }
            }
            spinvalue(energy, winprob);

            if (energy >= 4 && winprob > 60)
            {
                Console.WriteLine("You're a Winner!!!");
            }
            else
            {
                Console.WriteLine("You've Lost!!!");
            }
            Console.ReadKey();
        }
    }
}
