using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            //А
            ushort ush = 65535;
            Console.WriteLine($"Максимальное значение типа данных ushort = {ush}");

            //Б
            string str = "Произвольная123 строка c числом.";
            string str2 = "123";
            int index = str.IndexOf(str2);
            if (index == -1)
            {
                Console.WriteLine("Строка не содержит 123");
            }
            else
            {
                Console.WriteLine("Строка содержит 123");
            }

            //В
            double[,] Arr = new double[5, 5];
            Random r = new Random();
            for (int k = 0; k < 5; k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr[k, j] = r.Next(0, 15);
                    Console.Write("{0}\t", Arr[k, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
    //Задание 2
    class Date
    {
        public int day { get; set; }
        public int month { get; set; }
        readonly public int year;
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            Date stud = (Date)obj;
            return (this.day == stud.day && this.month == stud.month);
        }

    }
    //Задание 3
    interface IGood { void plus(); }
    interface IBad { void minus(); }
    public abstract class People
    {

    }
    class Student : People, IGood, IBad
    {
        public void plus()
        {

        }
        public void minus()
        {

        }
        void IGood.plus()
        {
            Console.Write("plus");
        }
        void IBad.minus()
        {
            Console.Write("minus");
        }
    }
    class Prepod : People, IGood, IBad
    {
        public void plus()
        {

        }
        public void minus()
        {

        }
        void IGood.plus()
        {
            Console.Write("plus2");
        }
        void IBad.minus()
        {
            Console.Write("minus2");
        }
    }
}
