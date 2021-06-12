using System;

namespace Data_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data inventory");
            DataRead dataRead = new DataRead();
            dataRead.GetData();
        }
    }
}
