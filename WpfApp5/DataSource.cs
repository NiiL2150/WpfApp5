using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WpfApp5
{
    class DataSource
    {
        private IEnumerable<Student> students;
        public DataSource()
        {
            students = new List<Student> { new Student("Dmitry", 19, 11.9f),
                new Student("Nail", 15, 12f, true),
                new Student("Kanan", 18, 10.9f, true),
                new Student("Javid", 17, 11f)
            };
        }
        public IEnumerable<Student> Students => students;
    }
}
