using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            //var list = new List<int> { 10, 20, 30, 40, };
            //var key = 50;
            //三項演算子
            //var num = list.Contains(key) ? 1 : 0;
            //Console.WriteLine(num);

            //string code = "12345";
            //null合体演算子
            //var message = GetMessage(code) ?? DefaultMessage();
            //Console.WriteLine(message);

            //var ret = GetProductA();

            //int count = 0;

            //Console.WriteLine($"後置:{count++}");
            //表示後に+1

            //Console.WriteLine($"前置:{++count}");
            //表示前に+1

            //var str = "123";
            ////int heigth;
            //if (int.TryParse(str,out var heigth)) {
            //    Console.WriteLine(heigth);
            //} else {
            //    Console.WriteLine("変換できません");
            //}

            var Session = new Dictionary<String, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if (product ==null) {
                //productが取得できなかった処理
                Console.WriteLine("productが取得できなかった");
            } else {
                //productが取得できた処理
                Console.WriteLine("productが取得できた");
            }



        }
        private static object DefaultMessage() {
            return "DefaultMessage";
        }
        private static object GetMessage(object code) {
            return code;
        }
        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            sale = null;
            return sale?.Product; //null条件演算子
        }
            
    }

    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }

}
