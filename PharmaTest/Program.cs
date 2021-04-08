using System;

namespace PharmaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Date manufDate = new Date(17, 04, 2020);
            Date expDate = new Date(17, 04, 2023);
            Medicine medStore = new Medicine(126464, "Vitamin-C", "Tuyil", 2000M, 40, manufDate, expDate, 0076);
            Sales saleDetails = new Sales(1223, 40, 340, 105, "Lagos");


            Console.WriteLine($"{medStore.Print(1277)}");
            Console.WriteLine($"{medStore.Print(2334, "Bunto")}");
            Console.WriteLine($"{saleDetails.Display()}");
            Console.WriteLine($"{saleDetails.Display(5466)}");
        }
    }
}
