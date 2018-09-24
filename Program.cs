using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты уравнения ");

            float A, B, C;

            A = Check("A=");
            B = Check("B=");
            C = Check("C=");

            if (A == 0) 
            {
                Console.WriteLine("Уравнение не квадратное и имеет один корень:");
                Console.WriteLine("х={0}", -C / B);
            }

            else
            {

                float Disk = B * B - 4 * A * C; //считаем дискриминант

                if (Disk < 0) { Console.WriteLine("Дискриминант меньше нуля, корней нет"); }
                else
                {
                    if (Disk == 0)
                    {
                        Console.WriteLine("Уравнение имеет один корень двойной кратности:");
                        Console.WriteLine("х1=х2={0}", -B / (2 * A));
                    }

                    else
                    {
                        double x1, x2;
                        x1 = (-B - Math.Sqrt(Disk)) / (2 * A);
                        x2 = (-B + Math.Sqrt(Disk)) / (2 * A);

                        Console.WriteLine("Уравнение имеет два корня:");
                        Console.WriteLine("х1={0}, x2={1}", x1, x2);
                    }

                }
            }

            Console.ReadLine();
        }



        static float Check(string str) //функция для проверки вводимых данных.
        {
            float k;
            bool result;

            do
            {
                Console.Write(str);
                string stroka = Console.ReadLine();//читаем строку
                result = float.TryParse(stroka, out k); //превращаем строку в цифру, суем ее в K и записываем в result инфу об исходе операции

                if (!result)
                {
                    Console.WriteLine("Вы ввели не число. Попробуйте еще раз");//возмущаемся, пока не введут цифру
                }
            }
            while (result == false);
            return k;
        }

    }
}