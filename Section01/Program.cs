using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {


            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };
            // 3.1.1
            //Exercise1_1(numbers);
            //Console.WriteLine("-----");

            // 3.1.2
            //Exercise1_2(numbers);
            //Console.WriteLine("-----");

            // 3.1.3
            //Exercise1_3(numbers);
            //Console.WriteLine("-----");

            // 3.1.4
            //Exercise1_4(numbers);


            // 3.2.1
            //Exercise2_1(names);
            //Console.WriteLine();

            ////// 3.2.2
            //Exercise2_2(names);
            //Console.WriteLine();

            //// 3.2.3
            //Exercise2_3(names);
            //Console.WriteLine();

            // 3.2.4
            //Exercise2_4(names);


            Exercise2_5(names);

            //Exercise3_2(names);

        }
        //②上記の文字列ではなく、キーボードから文字列（大文字小文字含むアルファベット）を１０個入力し、
　      //以下を選択して結果を表示する。

        private static void Exercise3_2(List<string> names) {
            Console.WriteLine("処理を選択");
            Console.WriteLine("１．小文字のカウント");
            Console.WriteLine("２．大文字のカウント");
            Console.WriteLine("３．数字のカウント");
            var line = Console.ReadLine();
            if (line.Equals(1)) {
                var count = line.Count(c => char.IsLower(c));

            } else if (line.Equals(2)) {
                var count = line.Count(c => char.IsUpper(c));

            } else if (line.Equals(3)) {
                var count = line.Count(c => char.IsDigit(c));
            } else {
                Console.WriteLine("選択外です");
            }
//            処理を選択
//　１．小文字のカウント
//　２．大文字のカウント
//　３．数字のカウント
//> 2

//大文字は１０個です
        }

        //①上記から、アルファベットの小文字だけをカウントする
        private static void Exercise2_5(List<string> names) {
            var count = 0;
            foreach (var name in names) {
              count += name.Count(c => char.IsLower(c));
               
            }
            Console.WriteLine(count);
        }

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(n => n % 8 == 0 || n % 9 ==0);
                if (exists) 
                        Console.WriteLine("存在しています");
                else 
                        Console.WriteLine("存在していません");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n /2.0) );
        }

        private static void Exercise1_3(List<int> numbers) {
            numbers.Where(n => n >= 50).ToList().ForEach(Console.WriteLine);
        } 
        private static void Exercise1_4(List<int> numbers) {
            var query = numbers.Select(n => n * 2).ToList();
            foreach (var n in query) {
                List<int> num = query;
                Console.WriteLine(n);
            }
        }
        private static void Exercise2_1(List<String> names) {
            Console.WriteLine("都市名を入力");
            var line = Console.ReadLine();
            var index = names.FindIndex(s => s == "line");
                Console.WriteLine(index);
        }
        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var where = names.Where(s => s.Contains('o')).ToArray();
            foreach (var str in where) {
                Console.WriteLine(str);

            }
        } 
        private static void Exercise2_4(List<string> names) {
            var query = names.Where(n => n.StartsWith("B")).Select(n=>n.Length);
            foreach (var str in query) {
                Console.WriteLine(str);
            }
        }
        
    }
        
}
