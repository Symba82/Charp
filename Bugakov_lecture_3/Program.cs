using System;

namespace Bugakov_lecture_3
{
    class Program
    {
        struct Complex
        {
            public double im;
            public double re;
            //  в C# в структурах могут храниться также действия над данными
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            //  Пример произведения двух комплексных чисел
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        class Complex2
        {
            // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.
            public double im;
            public double re;

            public Complex2 Plus(Complex2 x2)
            {
                Complex2 x3 = new Complex2();
                x3.im = x2.im + this.im;
                x3.re = x2.re + this.re;
                return x3;
            }

            public Complex2 Minus(Complex2 x2)
            {
                Complex2 x3 = new Complex2();
                x3.im = x2.im - this.im;
                x3.re = x2.re - this.re;
                return x3;
            }

            public Complex2 Multi(Complex2 x2)
            {
                Complex2 x3 = new Complex2();
                x3.im = x2.re* this.im + x2.im* this.re;
                x3.re = x2.re* this.re - x2.im * this.re;
                return x3;
            }

            public string ToString2()
            {
                return re + "+" + im + "i";
            }
        }



        static void Main(string[] args)
        {
            ///Арифметические действия с комплексными числами
            ///используя Структуру 
            #region Задача 1 а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            ///Вывод результата с помощью структуры 
            Console.WriteLine("Вывод результата арифметических вычеслений. Структура");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());


            Console.WriteLine(complex1.Minus(complex2).ToString());
            #endregion


            ///Арифметические действия с комплексными числами
            ///используя Структуру 
            #region Задача 1 б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

            Complex2 complex3 = new Complex2();           
            
            Complex2 complex4 = new Complex2();            

            // Ввод первого числа
            Console.WriteLine("Вывод комплексных чисел с помощью класса");
            Console.WriteLine("Введите дейсвительную часть первого числа");
            complex3.re = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого числа");
            complex3.im = Convert.ToInt32(Console.ReadLine());
            // Ввод второго числа
            Console.WriteLine("Введите дейсвительную часть второго числа");
            complex4.re = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго числа");
            complex4.im = Convert.ToInt32(Console.ReadLine());

            // Вывод варианта расчета
            Console.WriteLine("Для вывода результата вычитания, произведения или сложения комплексных чисел введите (- * +) ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "*":
                    Console.WriteLine(complex3.Multi(complex4).ToString2());

                    break;
                case "-":

                    Console.WriteLine(complex3.Minus(complex4).ToString2());

                    break;
                case "+":
                    Complex2 result2 = complex3.Plus(complex4);
                    Console.WriteLine(result2.ToString2());
                    break;
                default:
                    Console.WriteLine("Вы нажали неверный знак");
                    break;


            }
            #endregion


            #region Задача 2 С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
            int sum = 0;
            int num = 0;

            Console.WriteLine("Введите числа для подсчета суммы нечетных");
            do
            {
                
                bool flag = int.TryParse(Console.ReadLine(), out num);
                if (flag)
                {
                    if (num > 0 && num % 2 == 1)
                        sum += num;
                }
                else
                    Console.WriteLine("Вы ввели не верное значение");
               
                
            } while (num != 0);

            Console.WriteLine("Сумма всех нечетных чисел: " + sum);

            #endregion

        }
    }
}
