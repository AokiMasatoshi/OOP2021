using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            //フィートからメートルへの対応表を出力
                PrintInchToMeterList(1, 10);
        }



        private static void PrintInchToMeterList(int start, int stop) {
            for (int Inch = start; Inch <= stop; Inch++) {
                double meter = InchConverter.ToMeter(Inch);
                Console.WriteLine("{0}Inch = {1:0.0000}m", Inch, meter);
            }
        }
    }
}

