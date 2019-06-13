using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerApp
{
    class Program
    {
        static void PrintTime(object state)
        {
            Console.WriteLine("Time is: {0} -{1}",
            DateTime.Now.ToLongTimeString(), state.ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Working with Timer type *****\n");
            // Создать делегат для типа Timer.
            TimerCallback timeCB = PrintTime;

            // Установить параметры таймера.
            Timer t = new Timer(
            timeCB, //	Объект делегата TimerCallback.
            "Текущее время",   //	Информация для передачи в вызванный метод
                    // (null — информация отсутствует).
            5000,  //	Период времени ожидания перед запуском (в миллисекундах).
            1000);  //	Интервал рремени между вызовами (в миллисекундах).
            Console.WriteLine("Hit key to terminate...");
            Console.ReadLine();
        }
    }
}
