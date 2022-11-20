using System;
using pro100user.task2;
using pro100user.task3;

namespace pro100user 
{
    /*
     * Лабараторна робота №5
     * Ткачука Богдана група 341ск
     * Варіант 22
     */
    public class Lab5
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Завдання 1-2");
                Console.WriteLine("2. Завдання 3");
                Console.WriteLine("3. Вихід");
                Console.Write("Введіть вибране число: ");
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == 3)
                    {
                        Console.WriteLine("Вихід...");
                        return;
                    }

                    switch (number)
                    {
                        case 1:
                            Task1AndTask2();
                            break;
                        case 2:
                            Task3();
                            break;
                        default:
                            Console.WriteLine("Ви ввели не те число. Повторіть спробу");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nВи не правильно ввели число. Повторіть спробу");
                }
                Console.WriteLine();
            }
        }
        
        /*
         * Завдання 1.
         * Побудувати ієрархію класів відповідно до варіантазавдання.
         * Згідно завдання вибрати базовий клас та похідні.
         * В класах задати поля, які характерні для кожного класу.
         * Для всіх класів розробити метод Show(), який виводить дані про об’єкт класу.
         *
         * Завдання 2.
         * До побудованої ієрархії класів з завдання 1
         * додати конструктори та деструктори в який виводити повідомлення в консоль.
         * Продемонструвати порядок виклику конструкторів та деструкторів.
         * У класах передбачити не менше 3 (трьох) конструкторів.
         *
         * 2.7. Тест, іспит, випускний іспит, випробування.
         */
        static void Task1AndTask2()
        {
            List<Examination> examinations = new List<Examination>()
            {
                new Examination(),
                new Test(),
                new Exam(),
                new FinalExam()
            };
            examinations.ForEach(exam => exam.Show()); 
        }
        
        /*
         * Завдання 3.
         * Побудувати ієрархію класів відповідно до варіанта завдання.
         * Згідно завдання вибрати базовий клас та похідні.
         * В класах задати задати вмістиме для кожного класу.
         *
         * 3.2. Створити абстрактний клас Function з методом обчислення значення функції y=f(x) у заданій точці.
         * Створити похідні класи: Line (y=ax+b), Quadratic (y=ax2+bx+c), Hyperbola (y=k/x)
         * зі своїми методами обчислення значення в заданій точці.
         * Створити масив nфункцій і вивести повну інформацію про значення даних функцій у точці х.
         */
        static void Task3()
        {
            double x = 5;
            List<Function> functions = new List<Function>()
            {
                new Line(1, 2, x),
                new Quadratic(1, 2, 3, x),
                new Hyperbola(3, x)
            };
            functions.ForEach(func => Console.WriteLine(func.CalculateY())); 
        }
    }
}
