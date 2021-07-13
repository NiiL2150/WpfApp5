using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class Student
    {
        string fullName;
        int age;
        float score;

        public Student(string fullName, int age, float score, bool isStudy = false)
        {
            this.fullName = fullName;
            this.age = age;
            this.score = score;
            this.IsStudy = isStudy;
        }

        public string FullName => fullName;
        public int Age => age;
        public float Score => score;
        public bool IsStudy { get; set; }

        public override string ToString()
        {
            return $"{this.fullName}; {this.age}; {this.score}; {(IsStudy ? "Studying" : "Not studying")}";
        }
    }
}
