using System;
namespace Reverse {
    class Program {
        static void Main(string[] args) {
            double[] data = { 8.5, 12.0, 23.2, 18.0, 15.5, 5.0, 10.5 };
            Reverse(data, 2, 5);
            foreach(double element in data) {
                Console.Write(element + " ");
            }          
            Console.ReadKey();
        }
        public static void Reverse(double[] values, int start, int finish) {
            double firstNum = values[start]; // copy first positions element
            values[start] = values[finish]; //Assign to second element
            values[finish] = firstNum; // assign to first element.
        }
    }
}
