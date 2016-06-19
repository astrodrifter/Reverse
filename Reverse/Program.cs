using System;
namespace Reverse {
    class Program {
        static void Main(string[] args) {
            double[] data = { 8.5, 12.0, 23.2, 18.0, 15.5, 5.0, 10.5 };
            Reverse(data, 2, 4); // in question it says 2 and 5.
            foreach(double element in data) {
                Console.Write(element + " ");
            }          
            Console.ReadKey();
        }
        public static void Reverse(double[] values, int start, int finish) {
            Array.Reverse(values, start, finish);
        }
    }
}
