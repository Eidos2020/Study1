using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_к_1_занятию
{
    class Program
    {
        static void Pause () 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Пауза. Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.ResetColor();
        }

        static void PrintIn (string msg, int x, int y) 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static double LineCount (double x1, double y1, double x2, double y2)
        {
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            return r;
        }

        static void Main(string[] args)
#region
        {
            // студент - Лоханин Антон Михайлович
            //Задание 1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку.
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            // Каждый новый вопрос сделан с помощью нового метода.


            Console.WriteLine("Добрый день. Пожалуйста заполните анкету, ответив на несколько простых вопросов.");
            // Вопрос 1. Склейка.
            Console.WriteLine("1. Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Итак, вас зовут " + name + ".");
            // Вопрос 2. Форматированный вывод.
            Console.WriteLine("2. Сколько вам лет, {0}?", name);
            String age = Console.ReadLine();
            Console.WriteLine("Понятно, {0}. Вам {1}.", name, age);
            // Вопрос 3. Через $
            Console.WriteLine($"3. Каков ваш рост, {name}? (в сантиметрах)");
            String height = Console.ReadLine();
            Console.WriteLine("Понятно.");
            // Вопрос 4. Снова склейка.
            Console.WriteLine("И последний вопрос " + name + ". Сколько вы весите? (в килограммах)");
            String weight = Console.ReadLine();

            // Итоговый вывод.
            Console.WriteLine($"Давайте подитожим.");
            //1. Склейка.
            Console.WriteLine("Вас зовут " + name + ", вам " + age + ". Ваш рост - " + height + " сантиметров, и ваш вес " + weight + " килограмм. (склейка)");
            //2. Форматированный вывод.
            Console.WriteLine("Вас зовут {0}, вам {1}. Ваш рост - {2} сантиметров, и ваш вес {3} килограмм. (формат)", name, age, height, weight);
            //3. Через $
            Console.WriteLine($"Вас зовут {name}, вам {age}. Ваш рост - {height} сантиметров, и ваш вес {weight} килограмм.(через $)");
            Console.WriteLine($"Большое спасибо {name}.");
            Pause();
            #endregion
            #region
            ////Задание 2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах

            // Ввод данных
            Console.WriteLine($"Теперь давайте вычислим ваш индекс массы тела {name}.");
            // Перевожу строковый рост в формат дабл
            double heightInt = 0;
            heightInt = Convert.ToDouble(height);
            // Перевожу сантиметры в метры (я знаю что их проще было задать сразу как дабл, но мне было интересно научиться их переводить)
            heightInt /= 100;
            // Перевожу строковый вес в формат дабл
            double weightInt = 0;
            weightInt = Convert.ToDouble(weight);
            // Вычисляю индекс массы тела по формуле и вывожу на экран.
            double i = weightInt / (heightInt * heightInt);
            Console.WriteLine($"Ваш индекс массы тела {i}.");
            // Оценка индекса массы тела.
            if ((i <= 25) && (i > 18))
            {
                Console.WriteLine($"{name}, у вас нормальный вес. Поздравляю.");
            }
            if ((i <= 30) && (i > 25))
            {
                Console.WriteLine($"{name}, у вас лишний вес.");
            }
            if (i > 30)
            {
                Console.WriteLine($"{name}, да вы клинический жиробас! Это опасно. Честно. Сходите к врачу.");
            }
            else
            {
                Console.WriteLine($"{name}, да вы дистрофик! Срочно съеште что нибудь!");
            }
            Pause();
            #endregion
            #region
            //Задание 3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);


            // Ввод координат точки 1 и 2.
            Console.WriteLine("Введите координаты точки 1 по оси х");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки 1 по оси y");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки 2 по оси х");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(("Введите координаты точки 2 по оси y"));
            double y2 = Convert.ToDouble(Console.ReadLine());
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            LineCount(x1, y1, x2, y2);
            Console.WriteLine("{0:F2}", r);
            Pause();

            #endregion
            #region
            //Задание 4.Написать программу обмена значениями двух переменных.
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            // а) с использованием третьей переменной;
            Console.WriteLine("Присвойте переменной varA любое значение.");
            String varA = Console.ReadLine();
            String varB = varA;
            String varC = varB;
            Console.WriteLine($"Теперь значение varC {varC}.");
            // б) *без использования третьей переменной.
            Console.WriteLine("Присвойте переменной varA любое значение.");
            varA = Console.ReadLine();
            varC = varA;
            Console.WriteLine($"Теперь значение varC {varC}.");
            Pause();
            #endregion
            #region
            //Задание 5.
            Console.Clear();
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Console.WriteLine("Антон Лоханин, Ярославль.");
            //б) Сделать задание, только вывод организуйте в центре экрана
            Console.SetCursorPosition((Console.WindowWidth/2)-13,Console.WindowHeight/2);
            Console.WriteLine("Антон Лоханин, Ярославль.");
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            PrintIn("Эта надпись результат работы метода PrintIn", (Console.WindowWidth/2)-20, 5);
            Pause();

            #endregion
            #region

            //Задание 6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

            // Метод Пауза
            Pause();
            // Так же в тексте программы выше использованы методы PrintIn и LineCount
            
            #endregion

        }
    }
}
