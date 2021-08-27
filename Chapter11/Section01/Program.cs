using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section01
{
    class Program
    {
        static void Main(string[] args)
        {
            var novelists = ReadNovelist();


            foreach (var novelist in novelists)
            {
                Console.WriteLine("{0} ({1} - {2}) - {3}",
                    novelist.Name,novelist.Birth.Year,novelist.Death.Year,
                    string.Join(",",novelist.MasterPieces));

            }
        }
        //カスタムクラスのオブジェクトとして要素を取り出す
        static public IEnumerable<Novelist> ReadNovelist()//XMLファイルのロード
        {
            
            var xdox = XDocument.Load("novelists.xml");

            var novelists = xdox.Root.Elements()
                        .Select(x => new Novelist{
                            Name = (string)x.Element("name"),
                            KanaName = (string)(x.Element("name").Attribute("kana")),
                            Birth = (DateTime)x.Element("birth"),
                            Death = (DateTime)x.Element("death"),
                            MasterPieces = x.Element("masterPieces")
                                           .Elements("title")
                                           .Select(title => title.Value)
                                           .ToArray()
                        }) ;
            return novelists.ToArray();
        }
    }
}


