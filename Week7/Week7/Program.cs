using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(func); // объект потока
            myThread.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Potok 1 vivodit " + i);
                Thread.Sleep(0); // поток должен приостановиться для того чтобы дать возможость выполнения другому потоку
            }
            Console.Read(); // для того чтобы коносоль не закрылась раньше времени, мы будем ожидать ввода с клавиатуры
        }
        static void func()
        {
            for (int i=0;i<10;i++)
            {
                Console.WriteLine("Potok 2 vivodit  " + i.ToString());
                Thread.Sleep(0);
            }
        }
    }
}
