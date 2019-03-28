using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2
{
    class Program
    {
        class myThread
        {
            Thread thread;

            public myThread(string name, int num) // конструктор получает имя функции и номер до которого ведет счет 
            {
                thread = new Thread(this.func);// создаем поток, связанный с функц func данного объекта
                thread.Name = name; // присваиваем потоку имя
                thread.Start(num); // передача параметра в поток
            }
            void func(object num) // функция потока, передаем параметр / функция вызываемая потоком может принимать только 1 аргумент, и только типа обджект
            {
                for (int i=0;i<(int)num; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "vivodit " + i);
                    Thread.Sleep(0);
                }
                Console.WriteLine(Thread.CurrentThread.Name + "zaverwilsya");
            }

        }
        static void Main(string[] args)
        {
            myThread t1 = new myThread("Thread 1", 6);
            myThread t2 = new myThread("Thread 2", 3);
            myThread t3 = new myThread("Thread 3", 2);

            Console.Read();

        }
    }
}
