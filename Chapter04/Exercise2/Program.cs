using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var ymCollection = new YearMonth[5] {
            new YearMonth (1999, 1),
            new YearMonth(2001, 5),
            new YearMonth(2004, 7),
            new YearMonth(2009, 9),
            new YearMonth(2015, 12),
        };
            Exercise2_2(ymCollection);
            Console.WriteLine("-----");

            Exercise2_4(ymCollection);
            Console.WriteLine("-----");

            Exercise2_5(ymCollection);
            Console.WriteLine("-----");

        }

        private static void Exercise2_2(YearMonth[] ymCollection) {

            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);

            }
        }

         static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Cevtury) {
                    return ym;
                }
            }
            return null;
        }


        private static void Exercise2_4(YearMonth[] ymCollection) {
            var ymCheck = FindFirst21C(ymCollection);

            //if (ymCheck!= null) {
            //    Console.WriteLine(ymCheck.Year);
            //} else {
            //    Console.WriteLine("21世紀のデータはありません");
            //}
            var s = ymCheck != null ? ymCheck.Year.ToString() : "21世紀のデータはありません";
            Console.WriteLine(s);
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym=>ym.AddOneMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);

            }



        }
    }
}

