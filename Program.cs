using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задача 1. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            Random rnd = new Random();
            int a = rnd.Next(10, 99);
            Console.WriteLine(a % 2 == 0 ? "Четное" : "Нечетное");
            Console.Read();
            */


            /*Задача 2. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            Random rnd = new Random();
            int a = rnd.Next(1, 7);
            switch (a)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            Console.Read();
            */



            /*Задача 3. Даны три целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.
            int a, b, c;
            Console.WriteLine("Введите три целых положительных числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
            {
                a /= 2;
                b /= 2;
                c /= 2;
            }
            else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a++;
                b++;
                c++;
            }
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.Read();
            */



            /*Задача 4. Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».
            int a;
            Console.WriteLine("Введите количество баллов");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 90 && a <= 100)
            {
                Console.WriteLine("Отлично");
            }
            else if (a >= 70 && a <= 89)
            {
                Console.WriteLine("Хорошо");
            }
            else if (a >= 50 && a <= 69)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if (a < 50)
            {
                Console.WriteLine("Неудовлетворительно");
            }
            Console.Read();
            */



            /*Задача 5. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник. Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя). 
            int a, b, c;
            Console.WriteLine("Введите признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник");
            char s = char.Parse(Console.ReadLine());
            switch (s)
            {
                case 'к':
                    Console.WriteLine("Введите радиус круга");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Периметр круга = {0}, площадь круга = {1}", 2 * Math.PI * a, Math.PI * a * a);
                    break;
                case 'п':
                    Console.WriteLine("Введите стороны прямоугольника");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Периметр прямоугольника = {0}, площадь прямоугольника = {1}", 2 * (a + b), a * b);
                    break;
                case 'т':
                    Console.WriteLine("Введите стороны треугольника");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Периметр треугольника = {0}, площадь треугольника = {1}", a + b + c, Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)));
                    break;
            }
            */



            /*Задача 6. Написать приложение, которое позволяет вычислить сумму страхового взноса (SV) для автомобиля. Входные данные будут вводиться с клавиатуры:
            string MA;
            int Months;
            Console.WriteLine("Введите марку автомобиля");
            MA = Console.ReadLine();
            Console.WriteLine("Введите срок страхования");
            Months = Convert.ToInt32(Console.ReadLine());
            double Kt;
            if (Months < 3)
            {
                Kt = 10;
            }
            else if (Months >= 3 && Months < 6)
            {
                Kt = 8;
            }
            else
            {
                Kt = 5;
            }
            double Sum = 50 * Months * (1 + Kt / 100);
            Console.WriteLine("Ваш автомобиль марки {0} был застрахован. Сумма страхового взноса составила {1}", MA, Sum);
            Console.Read();
            */
        }
    }
}
