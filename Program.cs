using ConsoleApp27;
using System;
using System.Collections.Generic;
internal class Program
{

    static void Main(string[] args)
    {
        string tort1 = "";
        string tort2 = "";
        string tort3 = "";
        string tort4 = "";
        string tort5 = ""; 
        string tort6 = "";

        Console.WriteLine("Заказ тортов в ГЛАЗУРЬКА, торты на ваш выбор!\nВыберите параметр торта\n-----------------------");
        Console.WriteLine("  Форма торта\n  Размер торта\n  Вкус коржей\n  Количество коржей\n  Глазурь\n  Декор\n  Конец заказа");
        Console.WriteLine("Для того, чтобы посмотреть заказ, выберите параметр 'Конец заказа'");

        int pos = Menu.Show(3, 9);
        Console.Clear();

       

        if (pos == 3)
        {

            Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню\n---------------------");
            Console.WriteLine("  Круг - 500\n  Квадрат - 500\n  Сердечко - 700");
            int pos2 = Menu.Show(3, 5);
            
            if (pos2 == 3)
            {


                Console.Clear();
                Main(new string[] { });

                tort1 = "Круг - 500";

            }
            if (pos2 == 4)
            {
                Console.Clear();
                Main(new string[] { });

                tort1 = "Квадрат - 500";
            }
            if (pos2 == 5)
            {
                Console.Clear();
                Main(new string[] { });

                tort1 = "Сердечко - 500";
            }
            Console.WriteLine(tort1);
            
        }

        if (pos == 4)
        {
            Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню\n---------------------");
            Console.WriteLine("  Маленький (Диаметр 16см - 8 порций) - 1000\n  Обычный (Диаметр 18см - 10 порций) - 1200\n" +
                "  Большой (Диаметр 20см - 12 порций) - 1500");
            int pos2 = Menu.Show(3, 5);
            if (pos2 == 3)
            {

                Console.Clear();
                Main(new string[] { });

                tort2 = "Маленький (Диаметр 16см - 8 порций) - 1000";
            }
            if (pos2 == 4)
            {
                Console.Clear();
                Main(new string[] { });

                tort2 = "Обычный (Диаметр 18см - 10 порций) - 1200";
            }
            if (pos2 == 5)
            {
                Console.Clear();
                Main(new string[] { });

                tort2 = "Большой (Диаметр 20см - 12 порций) - 1500";

            }
            Console.WriteLine(tort2);
           
        }
        if (pos == 5)
        {
            Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню\n---------------------");
            Console.WriteLine("  Ванильный - 100\n  Шоколадный - 100\n  Кокосовый - 100");
            int pos2 = Menu.Show(3, 5);
            if (pos2 == 3)
            {
                Console.Clear();
                Main(new string[] { });

                tort3 = "Ванильный - 100";
            }
            if (pos2 == 4)
            {
                Console.Clear();
                Main(new string[] { });

                tort3 = "Шоколадный - 100";
            }
            if (pos2 == 5)
            {
                Console.Clear();
                Main(new string[] { });

                tort3 = "Кокосовый - 100";
            }
            Console.WriteLine(tort3);
            
        }
        if (pos == 6)
        {
            Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню\n---------------------");
            Console.WriteLine("  1 корж - 200\n  2 коржа - 300\n  3 коржа - 400");
            int pos2 = Menu.Show(3, 5);
            if (pos2 == 3)
            {
                Console.Clear();
                Main(new string[] { });

                tort4 = "1 корж - 200";
            }

            if (pos2 == 4)
            {
                Console.Clear();
                Main(new string[] { }); tort4 = "2 коржа - 300";
            }
            if (pos2 == 5)
            {
                Console.Clear();
                Main(new string[] { });

                tort4 = "3 коржа - 400";
            }
            Console.WriteLine(tort4);
           
        }
        if (pos == 7)
        {
            Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню\n---------------------");
            Console.WriteLine("  Шоколадная - 150\n  Ягодная - 150\n  Кремовая - 150");
            int pos2 = Menu.Show(3, 5);
            if (pos2 == 3)
            {
                Console.Clear();
                Main(new string[] { });

                tort5 = "Шоколадная - 150";
            }
            if (pos2 == 4)
            {
                Console.Clear();
                Main(new string[] { });

                tort5 = "Ягодная - 150";
            }
            if (pos2 == 5)
            {
                Console.Clear();
                Main(new string[] { });

                tort5 = "Кремовая - 150";
            }
            Console.WriteLine(tort5);
            
        }
        if (pos == 8)
        {
            Console.WriteLine("Для выхода нажмите Escape\nВыберите пункт из меню\n---------------------");
            Console.WriteLine("  Шоколад - 100\n  Драже - 150\n  Ягоды - 200");
            int pos2 = Menu.Show(3, 5);
            if (pos2 == 3)
            {
                Console.Clear();
                Main(new string[] { });

                tort6 = "Шоколад - 100";
            }
            if (pos2 == 4)
            {
                Console.Clear();
                Main(new string[] { });

                tort6 = "Драже - 150";
            }
            if (pos2 == 5)
            {
                Console.Clear();
                Main(new string[] { });

                tort6 = "Ягоды - 200";
            }
            Console.WriteLine("Ваш торт:\n " + tort6);
        }
       
        if (pos == 9)
        {
            File.WriteAllText("C:\\Users\\simaz\\OneDrive\\Рабочий стол\\учеба\\История заказов.txt", tort1);
            File.AppendAllText("C:\\Users\\simaz\\OneDrive\\Рабочий стол\\учеба\\История заказов.txt", tort2);
            File.AppendAllText("C:\\Users\\simaz\\OneDrive\\Рабочий стол\\учеба\\История заказов.txt", tort3);
            File.AppendAllText("C:\\Users\\simaz\\OneDrive\\Рабочий стол\\учеба\\История заказов.txt", tort4);
            File.AppendAllText("C:\\Users\\simaz\\OneDrive\\Рабочий стол\\учеба\\История заказов.txt", tort5);
            File.AppendAllText("C:\\Users\\simaz\\OneDrive\\Рабочий стол\\учеба\\История заказов.txt", tort6);

        }
    }
}
