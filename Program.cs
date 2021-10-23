using HomeTask2;
using System;

namespace HomeTask_8_1
{
    public delegate int CompareToDelegate(object value1, object value2);

    class Program
    {
        static void Main(string[] args)
        {
            var arrStr = new string[] { "Apple","Lemon","Banana" };

            Sort.BubbleSort(arrStr, (value1, value2) => (((string)value1).CompareTo((string)value2)));//1 приклад

            foreach (var item in arrStr)
            {
                Console.WriteLine(item);
            }

            var products = new Product[]
            {
               new Product("Apple",123,1000,22,DateTime.Now),
               new Product("Lemon",21,500,233,DateTime.Now.AddDays(-15)),
               new Product("Banana",14,32,53,DateTime.Now.AddDays(-10))
            };

            Sort.BubbleSort(products, (value1, value2) => (((Product)value1).CompareTo((Product)value2)));//2 приклад

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

        }
    }



}
