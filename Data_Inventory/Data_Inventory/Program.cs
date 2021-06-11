using System;

namespace Data_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataRead dataRead = new DataRead();
            dataRead.GetData();
        }
    }
}
