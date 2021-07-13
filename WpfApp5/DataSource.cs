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
        ICollection<int> nonNotifiableColl = new List<int> { 1, 2, 3, 4 };
        ICollection<int> notifiableColl = new ObservableCollection<int> { 1, 2, 3, 4 };

        public IEnumerable<int> NonNotifiableColl => nonNotifiableColl;
        public IEnumerable<int> NotifiableColl => notifiableColl;

        public void AddValueNotify()
        {
            notifiableColl.Add(notifiableColl.Count + 1);
        }
        public void AddValueNonNotify()
        {
            nonNotifiableColl.Add(nonNotifiableColl.Count + 1);
        }
    }
}
