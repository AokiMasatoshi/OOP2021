using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);


        }


        //メソッドの概要： Studentデータを読み取り、
        private static IEnumerable<Student> ReadScore(string filePath) {
            var student = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var Items = line.Split(',');
                var scores= new Student {
                    Name = Items[0],
                    Subject = Items[1],
                    Score = int.Parse(Items[2])
                };
                student.Add(scores);
            }
            return student;
            
        }

        //メソッドの概要： 科目別の得点の集計
        public IDictionary<string, int> GetPerStudentScore() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score;
                } else {
                    dict[student.Subject] = student.Score;
                }
            }
            return dict;




            
        }
    }
}
