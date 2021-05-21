﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            //フィートからメートルへの対応表を出力

            if (args.Length >= 1 && args[0] == "-tom") {
                for (int feet = 1; feet <= 10; feet++) {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine("{0}ft = {1:0.0000}m", feet, meter);
                }
            } else {
                for (int meter = 1; meter <= 10; meter++) {
                    double feet = MeterToFeet(meter);
                    Console.WriteLine("{0}m = {1:0.0000}ft", meter, feet);
                }
            }
        }

        private static double MeterToFeet(int meter) {
            return meter/0.3048;
        }

        //フィートからメートルを求める
        private static double FeetToMeter(int feet) { 
            return feet * 0.3048;
        }
    }
}

