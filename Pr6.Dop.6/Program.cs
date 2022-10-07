using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte var1 = 250; //присвоение локальной переменной "var1" целого типа "byte"
            byte var2 = 150; //присвоение локальной переменной "var2" целого типа "byte"
            try //использование блока "try" для разбиения на разделы кода, который может затрагиваться исключением.
            {
                byte sum = checked((byte)(var1 + var2)); //Ключевое слово checked используется для явного включения проверки переполнения при выполнении арифметических операций и преобразований с данными целого типа
                Console.WriteLine("Сумма: {0}", sum); // вывод на экран строки "...".
            }
            catch (OverflowException ex) //Исключение, которое выбрасывается, когда при выполнении арифметических операций, операций приведения типов и преобразования происходит переполнение.
            {
                Console.WriteLine(ex.Message); //Вызов консоли для предотвращения предупреждающего сообщения.
                Console.ReadLine(); //считывание данных.
            }

        }
    }
}
